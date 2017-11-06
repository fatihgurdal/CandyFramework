using CandyFramework.Core.Interface.Entity;
using CandyFramework.Entity.Entity.Entity;
using CandyFramework.Entity.Interface.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyFramework.Entity.Interface.Entity
{
    public interface IUserGroupEntity : IUserGroup, ICreateEntity, IUpdateEntity, IEntity
    {
        ICollection<UserEntity> Users { get; set; }
    }
}
