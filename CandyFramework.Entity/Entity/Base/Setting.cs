using CandyFramework.Core.Enum;
using CandyFramework.Entity.Interface.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyFramework.Entity.Entity.Base
{
    public abstract class Setting : ISetting
    {
        public int Id { get; set; }
        public string KeyName { get; set; }
        public string Value { get; set; }
    }
}
