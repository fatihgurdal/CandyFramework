using CandyFramework.Core.Interface.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyFramework.Entity.Interface.Base
{
    public interface IUserGroup : IKeyEntity, IState
    {
        string Name { get; set; }
    }
}
