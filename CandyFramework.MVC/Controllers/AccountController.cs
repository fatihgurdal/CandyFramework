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
    [AuthorizeFilter]
    public class AccountController : BaseController
    {
        private readonly IUserService _userService;
        public AccountController(IUserService userService)
        {
            _userService = userService;
        }
        [AuthorizeFilter]
        public ActionResult Index()
        {
            AccountIndexModel model = new AccountIndexModel();

            List<UserView> users = _userService.All();
            model.Users = users;

            return View(model);
        }
        [AuthorizeFilter(false)]
        public ActionResult Login()
        {
            return View();
        }
    }
}