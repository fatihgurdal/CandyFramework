using CandyFramework.Core.Enum;
using CandyFramework.Core.Interface.Entity;
using CandyFramework.Entity.Entity.ViewModel;
using CandyFramework.Entity.Interface.Entity;
using CandyFramework.Entity.Interface.ViewModel;
using Mapster;
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
        public virtual UserGroupEntity UserGroup { get; set; }
        public override int UserGroupId { get; set; }

        public UserEntity()
        {

        }
        public UserEntity(UserEntity entity, UserGroupEntity UserGroup)
        {
            entity.Adapt<UserEntity, UserEntity>(this);
            this.UserGroup = UserGroup;
        }
        public UserView Map()
        {
            if (this.UserGroup != null)
                this.UserGroup.Users = null;
            //Entity to View Model
            var result = this.Adapt<UserView>();
            //byte array to Base64String
            if (ProfilPhoto != null && ProfilPhoto.Length > 0)
            {
                result.ProfilPhotoBase64 = Convert.ToBase64String(this.ProfilPhoto);
            }
            //FirstName and LastName to Full Name
            result.FullName = $"{this.FirstName} {this.LastName}";

            return result;
        }
    }
}
