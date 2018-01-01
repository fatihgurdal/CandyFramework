using CandyFramework.BusinessLayer.Interface;
using CandyFramework.Entity.Entity.ViewModel;
using CandyFramework.DataAccessLayer.Interface;
using CandyFramework.Core.Concrete.Common;
using CandyFramework.Entity.Entity.Entity;

namespace CandyFramework.BusinessLayer.Concrete
{
    public class UserService : BaseService<UserEntity, UserView>, IUserService
    {
        #region - Repository -
        private readonly IUserRepository userRepository;
        #endregion
        public UserService(IUserRepository _userRepository) : base(_userRepository)
        {
            userRepository = _userRepository;
        }

        public UserView GetUserByPassword(string userName, string password)
        {
            return userRepository.GetUserByPassword(userName, password).Map();
        }

        public bool UserNamePasswordControl(string userName, string password)
        {
            return userRepository.UserNamePasswordControl(userName, password);
        }
    }
}
