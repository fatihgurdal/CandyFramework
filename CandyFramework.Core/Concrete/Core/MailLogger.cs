using CandyFramework.Core.Interface.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CandyFramework.Core.Enum;

namespace CandyFramework.Core.Concrete.Core
{
    public class MailLogger : ILogger
    {
        public void WriteLog(CandyLogType type, string detail)
        {
            WriteLog(type, "No Title", detail);
        }

        public void WriteLog(CandyLogType type, string title, string detail)
        {
            var logRow = $"{DateTime.Now} --->>{type.ToString()} Title:{title} {Environment.NewLine} Detail: {detail} {Environment.NewLine}";

            var mail = new CandyFramework.Common.Mails.Mail(Common.Setting.ErrorMail.ToMails, Common.Setting.Mail.MailAddress);
            mail.LoadSMTP(Common.Setting.Mail.MailAddress, Common.Setting.Mail.MailPassword, Common.Setting.Mail.SMTPHost, Common.Setting.Mail.SMTPPort, true);
            mail.BaseMail.Body = logRow;
            mail.BaseMail.Subject = "Error Log : " + Common.Setting.Mail.FromDisplayName;

            mail.SendAsync();
        }

        public void WriteLog(string title, Exception exception)
        {
            WriteLog(CandyLogType.Error, title, exception.ToString());
        }
    }
}
