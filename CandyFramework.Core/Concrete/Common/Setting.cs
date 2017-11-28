using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyFramework.Core.Concrete.Common
{
    public class Setting
    {
        public static SettingMail Mail { get; set; } = new SettingMail();
        public static SuperUser SuperUser { get; set; } = new SuperUser();
        public static ErrorMail ErrorMail { get; set; } = new ErrorMail();
        public static string LogClass { get; set; } = string.Empty;
    }
    public class SettingMail
    {
        public string SMTPHost { get; set; }
        public string SMTPPort { get; set; }
        public string MailAddress { get; set; }
        public string MailPassword { get; set; }
        public string FromDisplayName { get; set; }
    }
    public class SuperUser
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
    public class ErrorMail
    {
        public List<string> ToMails { get; set; }
        public List<string> CsMails { get; set; }
    }
}
