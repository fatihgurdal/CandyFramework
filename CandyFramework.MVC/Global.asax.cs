using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Http;
using CandyFramework.Application.Bootstrappers;
using CandyFramework.Core.Concrete.IoC;
using CandyFramework.MVC.Controllers;

namespace CandyFramework.MVC
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            var path = System.Web.Hosting.HostingEnvironment.ApplicationPhysicalPath;

            //IoC Register !!!!
            Bootstrapper.Instance.Bootstrap(new DependencyBootstrapper());

            //IoC Resolver !!!!
            var dependencyContainer = DependencyContainer.Current;

            var controllersAssembly = typeof(BaseController).Assembly;
            foreach (var controllerType in controllersAssembly.GetTypes().Where(t => typeof(BaseController).IsAssignableFrom(t) || typeof(Controller).IsAssignableFrom(t)))
            {
                dependencyContainer.Register(controllerType, controllerType);
            }

            DependencyResolver.SetResolver(new UIDependecyResolver());
            var settingServis = (BusinessLayer.Interface.ISettingService)dependencyContainer.Resolve(typeof(BusinessLayer.Interface.ISettingService));
            settingServis.LoadSettings();
        }
    }
    public class UIDependecyResolver : IDependencyResolver
    {
        private readonly IDependencyResolver _resolver = DependencyResolver.Current;

        public object GetService(Type serviceType)
        {
            if (typeof(IController).IsAssignableFrom(serviceType))
            {
                return DependencyContainer.Current.Resolve(serviceType);
            }
            return _resolver.GetService(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            if (typeof(IController).IsAssignableFrom(serviceType))
            {
                return new[] { DependencyContainer.Current.Resolve(serviceType) };
            }
            return _resolver.GetServices(serviceType);
        }
    }
}