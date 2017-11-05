using CandyFramework.Entity.Interface.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CandyFramework.Core.Enum;

namespace CandyFramework.Entity.Entity.Base
{
    public abstract class CandyLog : ICandyLog
    {
        public CandyLogType Type { get; set; }
        public string ErrorMessage { get; set; }
        public string ErrorDetail { get; set; }
        public string InnerException { get; set; }
        public int Level { get; set; }
        public string CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public int Id { get; set; }
    }
}
