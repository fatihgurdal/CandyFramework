using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyFramework.Entity.Interface.ViewModel.VirtualViewModel
{
    public interface ILogin
    {
        string UserName { get; set; }
        string Password { get; set; }
        string Language { get; set; }
        bool RememberMe { get; set; }
    }
}
