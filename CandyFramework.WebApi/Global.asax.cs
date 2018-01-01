using CandyFramework.Application.Bootstrappers;
using CandyFramework.Core.Concrete.IoC;
using CandyFramework.WebApi.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Dependencies;
using System.Web.Http.Dispatcher;
using System.Web.Routing;

namespace CandyFramework.WebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            /*GlobalConfiguration.Configuration.Services.Replace(typeof(IHttpControllerActivator), new WindsorCompositionRoot(this.container));

            //Get project settings and load settings
            var settingServis = dependencyContainer.Resolve(typeof(BusinessLayer.Interface.ISettingService));
            ((BusinessLayer.Interface.ISettingService)settingServis).LoadSettings();*/
        }
    }
    /*public class UIDependecyResolver : IDependencyResolver
    {
        private readonly IDependencyResolver _resolver = DependencyResolver.Current;

        public IDependencyScope BeginScope()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public object GetService(Type serviceType)
        {
            if (typeof(IHttpController).IsAssignableFrom(serviceType))
            {
                return DependencyContainer.Current.Resolve(serviceType);
            }
            return _resolver.GetService(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            if (typeof(IHttpController).IsAssignableFrom(serviceType))
            {
                return new[] { DependencyContainer.Current.Resolve(serviceType) };
            }
            return _resolver.GetServices(serviceType);
        }
    }*/
}
