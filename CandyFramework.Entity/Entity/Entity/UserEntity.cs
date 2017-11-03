using CandyFramework.Core.Enum;
using CandyFramework.Core.Interface.Entity;
using CandyFramework.Entity.Entity.ViewModel;
using CandyFramework.Entity.Interface.Entity;
using CandyFramework.Entity.Interface.ViewModel;
using System;

namespace CandyFramework.Entity.Entity.Entity
{
    public class UserEntity : Base.User, IUserEntity, IEntityMap<UserView>
    {
        public string Password { get; set; }
        public byte[] ProfilPhoto { get; set; }
        public string CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime UpdateDate { get; set; }

        public UserEntity()
        {

        }
        public UserView Map()
        {
            Base.User tempObject = this;

            UserView resultObject = (UserView)tempObject;
            resultObject.ProfilPhotoBase64 = Convert.ToBase64String(this.ProfilPhoto);
            resultObject.FullName = $"{this.FirstName} {this.LastName}";

            return (UserView)resultObject;
        }
    }
}
