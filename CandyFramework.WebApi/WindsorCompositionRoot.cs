using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;

namespace CandyFramework.WebApi
{
    public class WindsorCompositionRoot : IHttpControllerActivator
    {
        //TODO: Castle Windsor ayarları
        //private readonly IWindsorContainer container;
        public WindsorCompositionRoot()
        {

        }
        /*public WindsorCompositionRoot(IWindsorContainer container)
        {
            this.container = container;
        }*/

        public IHttpController Create(
            HttpRequestMessage request,
            HttpControllerDescriptor controllerDescriptor,
            Type controllerType)
        {
            /*var controller =
                (IHttpController)this.container.Resolve(controllerType);

            request.RegisterForDispose(
                new Release(
                    () => this.container.Release(controller)));

            return controller;*/
            throw new NotImplementedException();
        }

        private class Release : IDisposable
        {
            private readonly Action release;

            public Release(Action release)
            {
                this.release = release;
            }

            public void Dispose()
            {
                this.release();
            }
        }
    }
}