using CandyFramework.Core.Interface.DataAccess;
using CandyFramework.Entity.Entity.Entity;
using System.Collections.Generic;

namespace CandyFramework.DataAccessLayer.Interface
{
    public interface IUserRepository : IRepository<UserEntity>
    {
        bool UserNamePasswordControl(string userName, string password);
        UserEntity GetUserByPassword(string userName, string password);
        List<UserEntity> SearhUsers(string searchText);
    }
}
