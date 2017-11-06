using CandyFramework.Core.Enum;
using CandyFramework.Core.Interface.Entity;
using CandyFramework.Entity.Entity.Entity;
using CandyFramework.Entity.Interface.ViewModel;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyFramework.Entity.Entity.ViewModel
{
    public class UserGroupView : Base.UserGroup, IUserGroupView, IViewMap<UserGroupEntity>
    {
        public UserGroupView()
        {

        }

        public ICollection<UserView> Users { get; set; }

        public UserGroupEntity Map()
        {
            var result = this.Adapt<UserGroupEntity>();

            return result;
        }
    }
}
