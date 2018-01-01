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
using CandyFramework.Entity.Entity.ViewModel.VirtualViewModel;

namespace CandyFramework.MVC.Controllers
{
    [AuthorizeFilter]
    public class AccountController : BaseController
    {
        private readonly IUserService _userService;
        public AccountController(IUserService userService) : base()
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
        [AuthorizeFilter(false)]
        [HttpPost]
        public ActionResult Login(LoginView loginView)
        {
            if (_userService.UserNamePasswordControl(loginView.UserName, loginView.Password))
            {
                var aut = base.GetAut();
                var user = _userService.GetUserByPassword(loginView.UserName, loginView.Password);
                aut.SetLogonUser(new Core.Concrete.LogonUser()
                {
                    FullName = user.FullName,
                    UserId = user.Id,
                    UserName = user.UserName,
                    Lang = loginView.Language
                });
                return RedirectToAction("Index", "Account");
            }
            else
            {
                ViewBag.PageErrorText = "Kullanıcı adı ve şifre hatalı";
            }
            return View();
        }
        [AuthorizeFilter]
        public ActionResult Logout()
        {
            var aut = base.GetAut();
            aut.LogoutUser();
            return RedirectToAction("Login");
        }
    }
}