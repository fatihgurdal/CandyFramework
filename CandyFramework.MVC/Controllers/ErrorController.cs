using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CandyFramework.MVC.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult Index(bool? isErrorHanle)
        {

            var ex = (Exception)TempData["ErrorFilterException"];
            return View(ex);

        }
    }
}