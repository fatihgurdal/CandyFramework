using CandyFramework.BusinessLayer.Concrete;
using CandyFramework.BusinessLayer.Interface;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CandyFramework.MVC.DependencyInjection.Ninject
{
    public class MVCModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IUserService>().To<UserService>();
        }
    }
}