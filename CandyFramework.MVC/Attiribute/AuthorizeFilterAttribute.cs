using CandyFramework.Core.Concrete;
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
        {   }
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
                if (HttpContext.Current.Session["LoginObject"] != null)
                {
                    //Oturum açma
                    var user = (LogonUser)HttpContext.Current.Session["LoginObject"];
                    Core.Concrete.Common.ConnectionProvider.LogonUser = user;
                    base.OnActionExecuting(filterContext);
                }
                else
                {
                    // Kullanıcı giriş yapmamış demektir.
                    filterContext.Result = new RedirectResult("~/Account/Login");
                }
            }
        }
    }
}