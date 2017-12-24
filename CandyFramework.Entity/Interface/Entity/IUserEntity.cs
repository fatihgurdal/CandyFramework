using CandyFramework.Core.Interface.Entity;
using CandyFramework.Entity.Entity.Entity;
using CandyFramework.Entity.Interface.Base;

namespace CandyFramework.Entity.Interface.Entity
{
    public interface IUserEntity : IUser, ICreateEntity, IUpdateEntity, IEntity
    {
        string Password { get; set; }
        byte[] ProfilPhoto { get; set; }
        UserGroupEntity UserGroup { get; set; }
    }
}
