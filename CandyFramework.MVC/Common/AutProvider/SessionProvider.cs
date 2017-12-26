using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CandyFramework.Core.Concrete;

namespace CandyFramework.MVC.Common.AutProvider
{
    internal class SessionProvider : IAutProvider
    {
        public void Dispose()
        {
            
        }

        public LogonUser GetLogonUser()
        {
            var sessionObject = HttpContext.Current.Session["LoginObject"];
            if (sessionObject != null)
            {
                return (LogonUser)sessionObject;
            }
            else
            {
                return null;
            }

        }

        public void LogoutUser()
        {
            HttpContext.Current.Session.Remove("LoginObject");
        }

        public void SetLogonUser(LogonUser user)
        {
            HttpContext.Current.Session["LoginObject"] = user;
        }
    }
}