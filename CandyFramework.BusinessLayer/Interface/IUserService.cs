using CandyFramework.Entity.Entity.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyFramework.BusinessLayer.Interface
{
    public interface IUserService
    {
        bool UserNamePasswordControl(string userName, string password);
        UserView GetUserByPassword(string userName, string password);
    }
}
