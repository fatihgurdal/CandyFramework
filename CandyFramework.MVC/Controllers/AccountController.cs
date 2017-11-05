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

namespace CandyFramework.MVC.Controllers
{
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
            List<UserView> users = _userService.All();
            model.Users = users;
            //ILogger logger = new Logger();
            //logger.WriteLog("başlık", "içerik");
            return View(model);
        }
    }
}