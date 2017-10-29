using CandyFramework.Core.Enum;
using CandyFramework.Entity.Entity.ViewModel;
using CandyFramework.Entity.Interface.Entity;
using System;

namespace CandyFramework.Entity.Entity.Entity
{
    public sealed class UserEntity : Base.User, IUserEntity
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
            UserView tempObject = (UserView)(Base.User)this;
            tempObject.ProfilPhotoBase64 = Convert.ToBase64String(this.ProfilPhoto);
            tempObject.FullName = $"{this.FirstName} {this.LastName}";

            return tempObject;
        }
    }
}
