using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CandyFramework.Core.Concrete;
using Newtonsoft.Json;

namespace CandyFramework.MVC.Common.AutProvider
{
    internal class CookieProvider : IAutProvider
    {
        const string CookieName = "LogonObject";

        public void Dispose()
        {
        }

        public LogonUser GetLogonUser()
        {
            var cookie = HttpContext.Current.Request.Cookies[CookieName];
            if (cookie != null)
            {
                var result = JsonConvert.DeserializeObject<LogonUser>(cookie.Value);
                return result;
            }
            return null;
        }

        public void LogoutUser()
        {
            HttpContext.Current.Request.Cookies.Remove(CookieName);
        }

        public void SetLogonUser(LogonUser user)
        {
            var jsonString = JsonConvert.SerializeObject(user);

        }
    }
}