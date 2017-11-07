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
    public class UserView : Base.User, IUserView, IViewMap<UserEntity>
    {
        public string ProfilPhotoBase64 { get; set; }
        public string FullName { get; set; }
        public UserGroupView UserGroup { get; set; }

        public UserView()
        {

        }
        public UserEntity Map()
        {
            //var destObject = sourceObject.Adapt<TDestination>();
            var result = this.Adapt<UserEntity>();
            //UserEntity tempObject = (UserEntity)(Base.User)this;
            result.ProfilPhoto = Convert.FromBase64String(this.ProfilPhotoBase64);

            result.UserGroup = this.UserGroup?.Adapt<UserGroupEntity>();
            return result;
        }
    }
}
