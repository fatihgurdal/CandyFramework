using CandyFramework.Core.Interface.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CandyFramework.Core.Enum;

namespace CandyFramework.Core.Concrete.Core
{
    public class DbLogger : ILogger
    {
        public void WriteLog(CandyLogType type, string detail)
        {
            throw new NotImplementedException();
        }

        public void WriteLog(CandyLogType type, string title, string detail)
        {
            throw new NotImplementedException();
        }

        public void WriteLog(string title, Exception exception)
        {
            throw new NotImplementedException();
        }
    }
}
