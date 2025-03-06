using Microsoft.Office.Interop.Outlook;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Transactions;


using Outlook = Microsoft.Office.Interop.Outlook;
using Word = Microsoft.Office.Interop.Word;


namespace emailer
{


  public partial class Form2 : Form
  {


    public Form2()
    {
      InitializeComponent();
      LoadConfig();
    }

    private string configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.json");


    private void LoadConfig()
    {
      if (!File.Exists(configPath))
      {
        MessageBox.Show($"錯誤：無法找到檔案參數 'config.json'\n\n" +
            $"請確保 Excel 檔案已正確放置，\n檔名格式為：\n\nconfig.json",
            "缺少檔案", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      string json = File.ReadAllText(configPath);
      var config = JsonSerializer.Deserialize<ConfigModel>(json);

      if (config != null)
      {
        UserName.Text = config.UserName;
        To.Text = config.To;
        UserMail.Text = config.UserMail;
        CC.Text = config.CC;
        // **取得當前日期**
        string todayDate = DateTime.Now.ToString("M/d (dddd)"); // 格式範例：2/28 (星期五)
        // **設定 Subject**
        Subject.Text = $"{todayDate} 軟體部門 {UserName.Text} 工作日誌";

        MailContent.Text = config.MailContent.Replace("${DATE}", todayDate);
        SignNameAndTitle.Text = config.SignNameAndTitle;
        ContactInfo.Text = config.ContactInfo;
        ContactMail.Text = config.ContactMail;
      }
    }



    /// <summary>
    /// 打開outlook、把UI上、excel、圖片放進郵件
    /// 1.看excel有沒有存在，不存在就報錯，不要執行
    /// 2 建立 Outlook 應用程式
    ///  3 填寫需要的主旨等
    ///  4顯示 Outlook 郵件窗口
    ///  5 插入圖片
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ButtonOutlookClick(object sender, EventArgs e)
    {
      //step1
      string currentDir = Directory.GetCurrentDirectory();
      string excelPath = Path.Combine(currentDir, $"研發專案進度追蹤表-{UserName.Text}.xlsx");
      if (!File.Exists(excelPath))
      {
        MessageBox.Show($"錯誤：無法找到檔案 '{excelPath}'\n\n" +
            $"請確保 Excel 檔案已正確放置，\n檔名格式為：\n\n研發專案進度追蹤表-{UserName.Text}.xlsx",
            "缺少檔案", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return; // **直接 return，不繼續執行**
      }

      // step2 建立 Outlook 應用程式
      Outlook.Application outlookApp = new Outlook.Application();
      MailItem mailItem = (MailItem)outlookApp.CreateItem(OlItemType.olMailItem);


      //step 3 填寫需要的主旨等
      mailItem.Attachments.Add(excelPath);// 添加 Excel 附件
      mailItem.To = To.Text;// 設定收件人
      mailItem.CC = CC.Text;//副本
      mailItem.Subject = Subject.Text;//主旨
      mailItem.BodyFormat = OlBodyFormat.olFormatHTML;//設定一下輸入的格式
      mailItem.HTMLBody = GetHtmlBody();//加入內文

      mailItem.Display();// step 4顯示 Outlook 郵件窗口

      System.Threading.Thread.Sleep(500);// 等待 Outlook 加載，加載後再往下插入圖片

      AddImageToText(mailItem);//step5 插入圖片
    }



    private string GetHtmlBody()
    {
      // ✅ 轉換 RichTextBox 換行到 <br>
      string bodyContent = MailContent.Text.Replace("\r\n", "<br>").Replace("\n", "<br>");

      //把聯絡的東西加上藍字體、底線
      string contactMailFormatted = "";
      foreach (string line in ContactMail.Lines)
      {
        if (!string.IsNullOrWhiteSpace(line))
        {
          contactMailFormatted += $"<a href='mailto:{line}' style='color:blue; text-decoration: underline;'>{line}</a><br>";
        }
      }
      // 取得 SignNameAndTitle 的所有行
      string[] sign_name_lines = SignNameAndTitle.Lines;

      //讓第一行為粗體字
      string boldTitle = sign_name_lines.Length > 0 ? $"<b>{sign_name_lines[0]}</b>" : "";// 取得第一行（如果有值）
      string remainingText = sign_name_lines.Length > 1 ? string.Join("<br>", sign_name_lines.Skip(1)) : "";// 取得剩餘行（如果有多行）

      // 建立簽名內容
      string signature = boldTitle
                         + remainingText
                         + "<br>" + ContactInfo.Text.Replace("\r\n", "<br>").Replace("\n", "<br>")
                         + "<br>" + contactMailFormatted;

      // **產生 HTML 內文**
      string htmlBody = $@"
        <html>
        <head>
            <meta http-equiv='Content-Type' content='text/html; charset=utf-8' />
            <style> 
              body {{ font-family: 'Microsoft JhengHei'; font-size: 13px; }} 
              a {{ font-size: 13px; }}  /* 確保超連結也使用 10px */
              b {{ font-size: 13px; }}  /* 確保粗體文字也使用 10px */
            </style>
        </head>
        <body>
            {bodyContent}<br><br><br><br>
            {signature}<br>
        </body>
        </html>";
      return htmlBody;
    }


    /// <summary>
    /// 用word的物件  插入圖片，否則圖片寄出的時候會跑到附件去
    /// </summary>
    /// <param name="mailItem"></param>
    private void AddImageToText(MailItem mailItem)
    {
      // 獲取 Outlook 郵件的 Word 編輯器
      Inspector inspector = mailItem.GetInspector;
      Word.Document doc = (Word.Document)inspector.WordEditor;

      // 找到圖片插入點
      Word.Selection selection = doc.Application.Selection;
      selection.HomeKey(Word.WdUnits.wdStory);


      // 取得 `SignNameAndTitle` 最後一行
      string[] lines = SignNameAndTitle.Lines;
      string lastLine = lines.Length > 0 ? lines[lines.Length - 1] : "";

      if (!string.IsNullOrWhiteSpace(lastLine))
      {
        Microsoft.Office.Interop.Word.Find find = selection.Find;
        find.Text = lastLine;
        find.Execute();

        // **確保找到位置後，插入圖片**
        if (find.Found)
        {
          selection.MoveRight();
          selection.TypeParagraph();  // **這行會插入換行**
          string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "image.png");
          selection.InlineShapes.AddPicture(imagePath);
        }
      }
    }

    private void ButtonExcelClick(object sender, EventArgs e)
    {
      string fileName = $"研發專案進度追蹤表-{UserName.Text}.xlsx";
      string filePath = Path.Combine(Directory.GetCurrentDirectory(), fileName);

      if (File.Exists(filePath))
      {
        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
        {
          FileName = filePath,
          UseShellExecute = true
        });
      }
      else
      {
        MessageBox.Show($"檔案不存在: {filePath}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }

    }



    /// <summary>
    /// 以下把UI 儲存成json
    /// 1.MailContent.Text內有日期，轉成${DATE}儲存
    /// 2 存到json
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ButtonSaveClick(object sender, EventArgs e)
    {
      // step1 取得日期格式，例如 "3/3 (星期一)"
      string datePattern = @"\d{1,2}/\d{1,2} \(\s*星期[一二三四五六日]\s*\)";
      // 用正則表達式替換 MailContent 內的日期為 ${DATE}
      string updatedMailContent = System.Text.RegularExpressions.Regex.Replace(
        MailContent.Text, datePattern, "${DATE}"
      );

      var config = new ConfigModel
      {
        UserName = UserName.Text,
        To = To.Text,
        UserMail = UserMail.Text,
        CC = CC.Text,
        MailContent = updatedMailContent,  // ✅ 儲存時日期變成 ${DATE}
        SignNameAndTitle = SignNameAndTitle.Text,
        ContactInfo = ContactInfo.Text,
        ContactMail = ContactMail.Text
      };


      //step2
      var options = new JsonSerializerOptions
      {
        WriteIndented = true,
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
      };
      string json = JsonSerializer.Serialize(config, options);
      File.WriteAllText(configPath, json);

    }
  }
}
