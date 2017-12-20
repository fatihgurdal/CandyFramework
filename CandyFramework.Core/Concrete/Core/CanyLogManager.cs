using CandyFramework.Core.Interface.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CandyFramework.Core.Enum;

namespace CandyFramework.Core.Concrete.Core
{
    public class CanyLogManager: ILogger
    {
        public static ILogger Logger;
        public static ILogger CreateLogger()
        {
            if (Logger == null)
            {
                switch (Common.Setting.LogClass)
                {
                    case "DbLogger":
                        Logger = new DbLogger();
                        break;
                    case "FileLogger":
                        Logger = new FileLogger();
                        break;
                    case "MailLogger":
                        Logger = new MailLogger();
                        break;
                    default:
                        Logger = new FileLogger();
                        break;
                }
            }
            return Logger;
        }
        public void WriteLog(CandyLogType type, string detail)
        {
            Logger.WriteLog(type, detail);
        }
        public void WriteLog(CandyLogType type, string title, string detail)
        {
            Logger.WriteLog(type, title, detail);
        }
        public void WriteLog(string title, Exception exception)
        {
            Logger.WriteLog(title, exception);
        }
    }
}
