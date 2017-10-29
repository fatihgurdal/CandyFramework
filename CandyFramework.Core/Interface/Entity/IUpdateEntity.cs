using System;
using System.Collections.Generic;
using System.Text;

namespace CandyFramework.Core.Interface.Entity
{
    public interface IUpdateEntity : IEntity
    {
        string UpdateUser { get; set; }
        DateTime UpdateDate { get; set; }
    }
}
