using CandyFramework.Entity.Interface.ViewModel.VirtualViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyFramework.Entity.Entity.ViewModel.VirtualViewModel
{
    public class UserRegisterView : Base.User, IUserRegister
    {
        public string Password { get; set; }
        public string RePassword { get; set; }
    }
}
