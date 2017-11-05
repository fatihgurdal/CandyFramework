using CandyFramework.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyFramework.Core.Interface.Core
{
    public interface ILogger
    {
        void WriteLog(CandyLogType type, string detail);
        void WriteLog(CandyLogType type, string title, string detail);
        void WriteLog(string title, Exception exception);
    }
}
