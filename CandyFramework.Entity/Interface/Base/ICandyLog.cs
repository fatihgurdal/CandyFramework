using CandyFramework.Core.Enum;
using CandyFramework.Core.Interface.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyFramework.Entity.Interface.Base
{
    public interface ICandyLog : ICreateEntity, IKeyEntity, IEntity
    {
        CandyLogType Type { get; set; }
        string ErrorMessage { get; set; }
        string ErrorDetail { get; set; }
        string InnerException { get; set; }
        int Level { get; set; }
    }
}
