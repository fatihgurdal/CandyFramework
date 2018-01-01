using CandyFramework.MVC.Common.AutProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CandyFramework.MVC.Controllers
{
    public class BaseController : Controller
    {
        protected static string ApplicationName { get; private set; } = Core.Concrete.Common.Setting.SiteName;
        public BaseController()
        {
            ViewBag.ApplicationName = ApplicationName;
        }
        internal IAutProvider GetAut()
        {
            IAutProvider aut = new SessionProvider();
            return aut;
        }
    }
}