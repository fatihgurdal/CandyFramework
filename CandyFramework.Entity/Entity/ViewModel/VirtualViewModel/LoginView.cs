using CandyFramework.Entity.Interface.ViewModel.VirtualViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyFramework.Entity.Entity.ViewModel.VirtualViewModel
{
    public class LoginView : ILogin
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
        public string Language { get; set; }
    }
}
