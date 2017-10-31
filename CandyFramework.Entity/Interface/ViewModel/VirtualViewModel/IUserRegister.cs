using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyFramework.Entity.Interface.ViewModel.VirtualViewModel
{
    public interface IUserRegister
    {
        string Password { get; set; }
        string RePassword { get; set; }
    }
}
