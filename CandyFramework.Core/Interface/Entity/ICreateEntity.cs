using System;
using System.Collections.Generic;
using System.Text;

namespace CandyFramework.Core.Interface.Entity
{
    public interface ICreateEntity: IEntity
    {
        string CreateUser { get; set; }
        DateTime CreateDate { get; set; }
    }
}
