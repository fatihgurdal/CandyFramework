using CandyFramework.Core.Enum;
using CandyFramework.Core.Interface.Entity;
using CandyFramework.Entity.Entity.ViewModel;
using CandyFramework.Entity.Interface.Entity;
using CandyFramework.Entity.Interface.ViewModel;
using Mapster;
using System;
using System.Collections.Generic;

namespace CandyFramework.Entity.Entity.Entity
{
    public class UserGroupEntity : Base.UserGroup, IUserGroupEntity, IEntityMap<UserGroupView>
    {
        public string CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime UpdateDate { get; set; }

        public virtual ICollection<UserEntity> Users { get; set; } = new HashSet<UserEntity>();

        public UserGroupEntity()
        {

        }
        public UserGroupView Map()
        {
            var result = this.Adapt<UserGroupView>();

            return result;
        }
    }
}
