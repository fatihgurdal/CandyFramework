using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CandyFramework.MVC.Attiribute
{
    public class ErrorFilterAttiribute : ActionFilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            filterContext.ExceptionHandled = true;
            var ex = filterContext.Exception;

            var logger = Core.Concrete.Core.CanyLogManager.CreateLogger();
            logger.WriteLog(ex.Message, ex);


            filterContext.ExceptionHandled = true;
            filterContext.Controller.TempData["ErrorFilterException"] = filterContext.Exception;
            filterContext.Result = new RedirectResult("~/Error/Index");
        }
    }
}