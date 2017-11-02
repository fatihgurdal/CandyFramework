using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CandyFramework.MVC.Controllers
{
    public class AccountController : Controller
    {
        public AccountController()
        {

        }
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
    }
}