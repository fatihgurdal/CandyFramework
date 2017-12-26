using CandyFramework.Core.Concrete;
using CandyFramework.MVC.Common;
using CandyFramework.MVC.Common.AutProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CandyFramework.MVC.Attiribute
{
    public class AuthorizeFilterAttribute : ActionFilterAttribute
    {
        private bool Authorize { get; set; }
        public AuthorizeFilterAttribute() : this(true) { }
        public AuthorizeFilterAttribute(bool authorize)
        {
            Authorize = authorize;
        }
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (this.Authorize)
            {
                if (filterContext.ActionDescriptor != null)
                {
                    var attrs = filterContext.ActionDescriptor.GetCustomAttributes(typeof(AuthorizeFilterAttribute), true);
                    if (attrs.Any(x => ((AuthorizeFilterAttribute)x).Authorize == false))
                    {
                        base.OnActionExecuting(filterContext); return;
                    }
                }                
                using (IAutProvider aut = new SessionProvider())
                {
                    var user = aut.GetLogonUser();
                    if (user != null)
                    {                        
                        Core.Concrete.Common.ConnectionProvider.LogonUser = user; //Oturum bilgisi Thread e yazıldı
                        base.OnActionExecuting(filterContext);
                    }
                    else
                    {
                        filterContext.Result = new RedirectResult("~/Account/Login"); // Kullanıcı giriş yapmamış demektir. Login'e yönlendirme
                    }
                }

            }
        }
    }
}