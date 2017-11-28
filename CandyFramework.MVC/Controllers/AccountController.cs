using CandyFramework.BusinessLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CandyFramework.Entity.Entity.ViewModel;
using CandyFramework.MVC.Models;
using CandyFramework.Core.Interface.Core;
using CandyFramework.Core.Concrete.Core;
using CandyFramework.MVC.Attiribute;

namespace CandyFramework.MVC.Controllers
{
    [ErrorFilterAttiribute]
    public class AccountController : BaseController
    {
        private readonly IUserService _userService;
        public AccountController(IUserService userService)
        {
            _userService = userService;
        }
        // GET: Account
        public ActionResult Index()
        {
            AccountIndexModel model = new AccountIndexModel();
            System.Threading.Thread.Sleep(3000);
            List<UserView> users = _userService.All();
            model.Users = users;
            //ILogger logger = new Logger();
            //logger.WriteLog("başlık", "içerik");
            throw new Exception("da da da fatih mail loglama denemesi");
            return View(model);
        }
    }
}