using CandyFramework.BusinessLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CandyFramework.Entity.Entity.ViewModel;
using CandyFramework.DataAccessLayer.Interface;
using CandyFramework.Core.Concrete.Common;

namespace CandyFramework.BusinessLayer.Concrete
{
    public class UserService : IUserService
    {
        #region - Repository -
        private readonly IUserRepository userRepository;
        #endregion
        public UserService(IUserRepository _userRepository)
        {
            userRepository = _userRepository;
        }

        public UserView GetUserByPassword(string userName, string password)
        {
            return userRepository.GetUserByPassword(userName, password.Encrypt()).Map();
        }

        public bool UserNamePasswordControl(string userName, string password)
        {
            return userRepository.UserNamePasswordControl(userName, password.Encrypt());
        }
    }
}
