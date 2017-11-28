using CandyFramework.Core.Interface.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CandyFramework.Core.Enum;
using System.IO;

namespace CandyFramework.Core.Concrete.Core
{
    public class FileLogger : ILogger
    {
        private static string logFile
        {
            get
            {
                string logPath = Path.Combine(Environment.CurrentDirectory, @"Logs");

                if (!Directory.Exists(logPath))
                {
                    Directory.CreateDirectory(logPath);
                }
                string result = Path.Combine(logPath, DateTime.Now.ToString("yyyyMMdd") + ".txt");
                return result;
            }
        }

        public void WriteLog(CandyLogType type, string detail)
        {
            WriteLog(type, "No Title", detail);
        }

        public void WriteLog(CandyLogType type, string title, string detail)
        {
            var logRow = $"{DateTime.Now} --->>{type.ToString()} Title:{title} {Environment.NewLine} Detail: {detail} {Environment.NewLine}";
            File.AppendAllText(logFile, $"{logRow} {new string('-', 20)} {Environment.NewLine}");
        }

        public void WriteLog(string title, Exception exception)
        {
            WriteLog(CandyLogType.Error, title, exception.ToString());
        }
    }
}
