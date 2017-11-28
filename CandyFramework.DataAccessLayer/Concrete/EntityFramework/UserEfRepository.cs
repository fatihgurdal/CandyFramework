using CandyFramework.DataAccessLayer.Concrete.EntityFramework.Base;
using CandyFramework.DataAccessLayer.Concrete.EntityFramework.Context;
using CandyFramework.DataAccessLayer.Interface;
using CandyFramework.Entity.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyFramework.DataAccessLayer.Concrete.EntityFramework
{
    public class UserEfRepository : EntityFrameworkRepository<UserEntity, CandyContext>, IUserRepository
    {
        public UserEfRepository()
        {

        }
        public override IQueryable<UserEntity> AsQueryable()
        {
            return base._context.Users.Include("UserGroup");
        }
        /// <summary>
        /// Kullanıcı adı ve şifre ile kullanıcı bulma
        /// </summary>
        /// <param name="userName">Kullanıcı adı veya email</param>
        /// <param name="password">Şifrelenmiş şifre</param>
        /// <returns></returns>
        public UserEntity GetUserByPassword(string userName, string password)
        {
            return base.First(x => (x.UserName.Equals(userName, StringComparison.InvariantCultureIgnoreCase) || x.Email.Equals(userName, StringComparison.InvariantCultureIgnoreCase)) && x.Password == password);
        }

        public bool UserNamePasswordControl(string userName, string password)
        {
            return base.Any(x => (x.UserName.Equals(userName, StringComparison.InvariantCultureIgnoreCase) || x.Email.Equals(userName, StringComparison.InvariantCultureIgnoreCase)) && x.Password == password);
        }
    }
}
