namespace emailer
{
  partial class Form2
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      UserName = new TextBox();
      To = new TextBox();
      UserMail = new TextBox();
      CC = new TextBox();
      Subject = new TextBox();
      MailContent = new RichTextBox();
      SignNameAndTitle = new RichTextBox();
      ContactInfo = new RichTextBox();
      textBox6 = new TextBox();
      textBox7 = new TextBox();
      textBox8 = new TextBox();
      textBox9 = new TextBox();
      textBox10 = new TextBox();
      richTextBox4 = new RichTextBox();
      pictureBox1 = new PictureBox();
      ContactMail = new RichTextBox();
      button_Save = new Button();
      button_outlook = new Button();
      button_excel = new Button();
      ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
      SuspendLayout();
      // 
      // UserName
      // 
      UserName.BackColor = Color.FromArgb(56, 52, 52);
      UserName.BorderStyle = BorderStyle.FixedSingle;
      UserName.Font = new Font("Microsoft JhengHei UI", 9F);
      UserName.ForeColor = SystemColors.Window;
      UserName.Location = new Point(155, 17);
      UserName.Name = "UserName";
      UserName.Size = new Size(66, 23);
      UserName.TabIndex = 1;
      UserName.Text = "郭孟庭";
      UserName.TextAlign = HorizontalAlignment.Center;
      // 
      // To
      // 
      To.BackColor = Color.FromArgb(56, 52, 52);
      To.BorderStyle = BorderStyle.FixedSingle;
      To.ForeColor = SystemColors.Window;
      To.Location = new Point(61, 52);
      To.Name = "To";
      To.Size = new Size(929, 23);
      To.TabIndex = 2;
      To.Text = "nelson@genitec.com.tw; gtcrd02@genitec.com.tw; hsuan@genitec.com.tw; irene@genitec.com.tw; james@genitec.com.tw";
      // 
      // UserMail
      // 
      UserMail.BackColor = Color.FromArgb(56, 52, 52);
      UserMail.BorderStyle = BorderStyle.FixedSingle;
      UserMail.ForeColor = SystemColors.Window;
      UserMail.Location = new Point(297, 17);
      UserMail.Name = "UserMail";
      UserMail.Size = new Size(303, 23);
      UserMail.TabIndex = 3;
      UserMail.Text = "gtcrd20@genitec.com.tw";
      UserMail.Visible = false;
      // 
      // CC
      // 
      CC.BackColor = Color.FromArgb(56, 52, 52);
      CC.BorderStyle = BorderStyle.FixedSingle;
      CC.ForeColor = SystemColors.Window;
      CC.Location = new Point(61, 81);
      CC.Name = "CC";
      CC.Size = new Size(929, 23);
      CC.TabIndex = 4;
      CC.Text = "gtcrd20@genitec.com.tw;gtcrd24@genitec.com.tw;gtcrd27@genitec.com.tw;gtcrd33@genitec.com.tw";
      // 
      // Subject
      // 
      Subject.BackColor = Color.FromArgb(56, 52, 52);
      Subject.BorderStyle = BorderStyle.FixedSingle;
      Subject.ForeColor = SystemColors.Window;
      Subject.Location = new Point(61, 110);
      Subject.Name = "Subject";
      Subject.Size = new Size(929, 23);
      Subject.TabIndex = 5;
      Subject.Text = "114/ 2/28 (星期五) 軟體部門 郭孟庭 工作日誌";
      // 
      // MailContent
      // 
      MailContent.BackColor = Color.FromArgb(56, 52, 52);
      MailContent.BorderStyle = BorderStyle.None;
      MailContent.Font = new Font("Microsoft JhengHei UI", 12F);
      MailContent.ForeColor = SystemColors.HighlightText;
      MailContent.Location = new Point(12, 139);
      MailContent.Name = "MailContent";
      MailContent.Size = new Size(1058, 183);
      MailContent.TabIndex = 6;
      MailContent.Text = "Dear all,\n我是軟體部門的 郭孟庭\n附件是 2/28 ( 星期五 ) 的工作進度追蹤表，請查閱。";
      // 
      // SignNameAndTitle
      // 
      SignNameAndTitle.BackColor = Color.FromArgb(56, 52, 52);
      SignNameAndTitle.BorderStyle = BorderStyle.None;
      SignNameAndTitle.Font = new Font("Microsoft JhengHei UI", 12F);
      SignNameAndTitle.ForeColor = SystemColors.HighlightText;
      SignNameAndTitle.Location = new Point(12, 321);
      SignNameAndTitle.Name = "SignNameAndTitle";
      SignNameAndTitle.Size = new Size(1058, 57);
      SignNameAndTitle.TabIndex = 7;
      SignNameAndTitle.Text = "郭孟庭 Nicholas Kuo\n研發部 軟體高級工程師";
      // 
      // ContactInfo
      // 
      ContactInfo.BackColor = Color.FromArgb(56, 52, 52);
      ContactInfo.BorderStyle = BorderStyle.None;
      ContactInfo.Font = new Font("Microsoft JhengHei UI", 12F);
      ContactInfo.ForeColor = SystemColors.HighlightText;
      ContactInfo.Location = new Point(12, 493);
      ContactInfo.Name = "ContactInfo";
      ContactInfo.Size = new Size(1058, 80);
      ContactInfo.TabIndex = 8;
      ContactInfo.Text = "412023 台中市大里區國中二路11號\nTel +886 4 2406-5816#335\nFax +886 4 2406-5688";
      // 
      // textBox6
      // 
      textBox6.BackColor = Color.FromArgb(32, 28, 28);
      textBox6.BorderStyle = BorderStyle.None;
      textBox6.Font = new Font("Microsoft JhengHei UI", 12F);
      textBox6.ForeColor = SystemColors.Window;
      textBox6.Location = new Point(70, 19);
      textBox6.Name = "textBox6";
      textBox6.Size = new Size(79, 21);
      textBox6.TabIndex = 11;
      textBox6.Text = "使用者名稱";
      // 
      // textBox7
      // 
      textBox7.BackColor = Color.FromArgb(32, 28, 28);
      textBox7.BorderStyle = BorderStyle.None;
      textBox7.Font = new Font("Microsoft JhengHei UI", 12F);
      textBox7.ForeColor = SystemColors.Window;
      textBox7.Location = new Point(244, 19);
      textBox7.Name = "textBox7";
      textBox7.Size = new Size(47, 21);
      textBox7.TabIndex = 12;
      textBox7.Text = "寄件者";
      textBox7.Visible = false;
      // 
      // textBox8
      // 
      textBox8.BackColor = Color.FromArgb(32, 28, 28);
      textBox8.BorderStyle = BorderStyle.None;
      textBox8.Font = new Font("Microsoft JhengHei UI", 12F);
      textBox8.ForeColor = SystemColors.Window;
      textBox8.Location = new Point(8, 54);
      textBox8.Name = "textBox8";
      textBox8.Size = new Size(47, 21);
      textBox8.TabIndex = 13;
      textBox8.Text = "收件者";
      // 
      // textBox9
      // 
      textBox9.BackColor = Color.FromArgb(32, 28, 28);
      textBox9.BorderStyle = BorderStyle.None;
      textBox9.Font = new Font("Microsoft JhengHei UI", 12F);
      textBox9.ForeColor = SystemColors.Window;
      textBox9.Location = new Point(25, 83);
      textBox9.Name = "textBox9";
      textBox9.Size = new Size(30, 21);
      textBox9.TabIndex = 14;
      textBox9.Text = "副本";
      // 
      // textBox10
      // 
      textBox10.BackColor = Color.FromArgb(32, 28, 28);
      textBox10.BorderStyle = BorderStyle.None;
      textBox10.Font = new Font("Microsoft JhengHei UI", 12F);
      textBox10.ForeColor = SystemColors.Window;
      textBox10.Location = new Point(25, 110);
      textBox10.Name = "textBox10";
      textBox10.Size = new Size(30, 21);
      textBox10.TabIndex = 15;
      textBox10.Text = "主旨";
      // 
      // richTextBox4
      // 
      richTextBox4.BackColor = Color.FromArgb(56, 52, 52);
      richTextBox4.BorderStyle = BorderStyle.None;
      richTextBox4.Location = new Point(286, 370);
      richTextBox4.Name = "richTextBox4";
      richTextBox4.ReadOnly = true;
      richTextBox4.Size = new Size(784, 124);
      richTextBox4.TabIndex = 16;
      richTextBox4.Text = "";
      // 
      // pictureBox1
      // 
      pictureBox1.Image = Properties.Resources.image;
      pictureBox1.Location = new Point(12, 378);
      pictureBox1.Name = "pictureBox1";
      pictureBox1.Size = new Size(277, 116);
      pictureBox1.TabIndex = 18;
      pictureBox1.TabStop = false;
      // 
      // ContactMail
      // 
      ContactMail.BackColor = Color.FromArgb(56, 52, 52);
      ContactMail.BorderStyle = BorderStyle.None;
      ContactMail.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Underline, GraphicsUnit.Point, 136);
      ContactMail.ForeColor = SystemColors.MenuHighlight;
      ContactMail.Location = new Point(12, 573);
      ContactMail.Name = "ContactMail";
      ContactMail.Size = new Size(1058, 58);
      ContactMail.TabIndex = 19;
      ContactMail.Text = "www.genitec.com.tw\ngtcrd20@genitec.com.tw";
      // 
      // button_Save
      // 
      button_Save.BackColor = Color.FromArgb(8, 108, 196);
      button_Save.BackgroundImageLayout = ImageLayout.Center;
      button_Save.FlatAppearance.BorderSize = 0;
      button_Save.FlatStyle = FlatStyle.Flat;
      button_Save.ForeColor = SystemColors.HighlightText;
      button_Save.Location = new Point(995, 15);
      button_Save.Name = "button_Save";
      button_Save.Size = new Size(75, 23);
      button_Save.TabIndex = 10;
      button_Save.Text = "儲存";
      button_Save.UseVisualStyleBackColor = false;
      button_Save.Click += ButtonSaveClick;
      // 
      // button_outlook
      // 
      button_outlook.BackColor = Color.FromArgb(8, 108, 196);
      button_outlook.BackgroundImageLayout = ImageLayout.Center;
      button_outlook.FlatAppearance.BorderSize = 0;
      button_outlook.FlatStyle = FlatStyle.Flat;
      button_outlook.ForeColor = SystemColors.HighlightText;
      button_outlook.Location = new Point(995, 93);
      button_outlook.Name = "button_outlook";
      button_outlook.Size = new Size(75, 24);
      button_outlook.TabIndex = 20;
      button_outlook.Text = "Outlook";
      button_outlook.UseVisualStyleBackColor = false;
      button_outlook.Click += ButtonOutlookClick;
      // 
      // button_excel
      // 
      button_excel.BackColor = Color.FromArgb(8, 108, 196);
      button_excel.BackgroundImageLayout = ImageLayout.Center;
      button_excel.FlatAppearance.BorderSize = 0;
      button_excel.FlatStyle = FlatStyle.Flat;
      button_excel.ForeColor = SystemColors.HighlightText;
      button_excel.Location = new Point(995, 54);
      button_excel.Name = "button_excel";
      button_excel.Size = new Size(75, 23);
      button_excel.TabIndex = 21;
      button_excel.Text = "Excel";
      button_excel.UseVisualStyleBackColor = false;
      button_excel.Click += ButtonExcelClick;
      // 
      // Form2
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      BackColor = Color.FromArgb(32, 28, 28);
      ClientSize = new Size(1075, 634);
      Controls.Add(button_excel);
      Controls.Add(button_outlook);
      Controls.Add(ContactMail);
      Controls.Add(pictureBox1);
      Controls.Add(richTextBox4);
      Controls.Add(textBox10);
      Controls.Add(textBox9);
      Controls.Add(textBox8);
      Controls.Add(textBox7);
      Controls.Add(textBox6);
      Controls.Add(button_Save);
      Controls.Add(ContactInfo);
      Controls.Add(SignNameAndTitle);
      Controls.Add(MailContent);
      Controls.Add(Subject);
      Controls.Add(CC);
      Controls.Add(UserMail);
      Controls.Add(To);
      Controls.Add(UserName);
      Name = "Form2";
      Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion
    private TextBox UserName;
    private TextBox To;
    private TextBox UserMail;
    private TextBox CC;
    private TextBox Subject;
    private RichTextBox MailContent;
    private RichTextBox SignNameAndTitle;
    private RichTextBox ContactInfo;
    private TextBox textBox6;
    private TextBox textBox7;
    private TextBox textBox8;
    private TextBox textBox9;
    private TextBox textBox10;
    private RichTextBox richTextBox4;
    private PictureBox pictureBox1;
    private RichTextBox ContactMail;
    private Button button_Save;
    private Button button_outlook;
    private Button button_excel;
  }
}