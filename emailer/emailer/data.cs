using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emailer
{
  //這個class 不能寫在form內，否則form會無法預覽UI
  public class ConfigModel
  {
    public string UserName { get; set; }
    public string To { get; set; }
    public string UserMail { get; set; }
    public string CC { get; set; }
    public string Subject { get; set; }
    public string MailContent { get; set; }
    public string SignNameAndTitle { get; set; }
    public string ContactInfo { get; set; }
    public string ContactMail { get; set; }
  }
}
