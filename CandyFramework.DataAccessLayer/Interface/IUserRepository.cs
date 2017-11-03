using CandyFramework.Core.Interface.DataAccess;
using CandyFramework.Entity.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyFramework.DataAccessLayer.Interface
{
    public interface IUserRepository : IRepository<UserEntity>
    {
        bool UserNamePasswordControl(string userName, string password);
        UserEntity GetUserByPassword(string userName, string password);
    }
}
