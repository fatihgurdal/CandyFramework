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

        public AuthorizeFilterAttribute() : this(true)
        { }
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
                        base.OnActionExecuting(filterContext);
                        return;
                    }
                }
                //Oturum bilgisi Session'a yazıldı
                using (IAutProvider aut = new SessionProvider())
                {
                    var user = aut.GetLogonUser();
                    if (user != null)
                    {
                        //Oturum bilgisi Thread e yazıldı
                        Core.Concrete.Common.ConnectionProvider.LogonUser = user;
                        base.OnActionExecuting(filterContext);
                    }
                    else
                    {
                        // Kullanıcı giriş yapmamış demektir. Login'e yönlendirme
                        filterContext.Result = new RedirectResult("~/Account/Login");
                    }
                }

            }
        }
    }
}