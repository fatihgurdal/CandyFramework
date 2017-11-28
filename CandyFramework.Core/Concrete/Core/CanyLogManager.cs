using CandyFramework.Core.Interface.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyFramework.Core.Concrete.Core
{
    public class CanyLogManager
    {
        public static ILogger CreateLogger()
        {
            switch (Common.Setting.LogClass)
            {
                case "DbLogger":
                    return new DbLogger();
                case "FileLogger":
                    return new FileLogger();
                case "MailLogger":
                    return new MailLogger();
                default:
                    return new FileLogger();
            }
        }
    }
}
