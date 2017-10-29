using System;
using System.Collections.Generic;
using System.Text;

namespace CandyFramework.Core.Interface.Entity
{
    public interface IGuildEntity: IEntity
    {
        string Id { get; set; }
    }
}
