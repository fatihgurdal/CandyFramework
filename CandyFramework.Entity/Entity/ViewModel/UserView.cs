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
        public string UserGroupName { get; set; }

        public UserView()
        {

        }
        public UserEntity Map()
        {
            //View Model to Entity
            var result = this.Adapt<UserEntity>();
            //Base64String to Byte Array
            result.ProfilPhoto = Convert.FromBase64String(this.ProfilPhotoBase64);

            return result;
        }
    }
}
