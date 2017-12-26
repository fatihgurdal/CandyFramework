using CandyFramework.Core.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyFramework.MVC.Common.AutProvider
{
    internal interface IAutProvider : IDisposable
    {
        LogonUser GetLogonUser();
        void SetLogonUser(LogonUser user);
        void LogoutUser();
    }
}
