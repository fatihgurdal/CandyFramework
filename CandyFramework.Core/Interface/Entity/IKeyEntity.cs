using System;
using System.Collections.Generic;
using System.Text;

namespace CandyFramework.Core.Interface.Entity
{
    public interface IKeyEntity: IEntity
    {
        int Id { get; set; }
    }
}
