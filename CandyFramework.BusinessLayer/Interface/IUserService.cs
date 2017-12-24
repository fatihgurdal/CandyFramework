using CandyFramework.Core.Interface.BusinessLayer;
using CandyFramework.Entity.Entity.ViewModel;

namespace CandyFramework.BusinessLayer.Interface
{
    public interface IUserService: IBaseService<UserView>
    {
        bool UserNamePasswordControl(string userName, string password);
        UserView GetUserByPassword(string userName, string password);
    }
}
