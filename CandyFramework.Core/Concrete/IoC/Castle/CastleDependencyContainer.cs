using CandyFramework.Core.Enum;
using CandyFramework.Core.Interface.Application;
using Castle.MicroKernel;
using Castle.MicroKernel.Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyFramework.Core.Concrete.IoC.Castle
{

    /// <summary>
    /// Castle implementation of IDependencyContainer
    /// </summary>
    public class CastleDependencyContainer : IDependencyContainer
    {
        /// <summary>
        /// The _kernel.
        /// </summary>
        private readonly IKernel _kernel = new DefaultKernel();

        /// <summary>
        /// Registers a service implementation for the given  service type withe given scope
        /// </summary>
        /// <param name="serviceType">The service type</param>
        /// <param name="classType">The service implementation type</param>
        /// <param name="scope">Scope of registration</param>
        /// <param name="singleton">Singleton instance if scope is singleton</param>
        /// <returns></returns>
        public IDependencyContainer Register(Type serviceType, Type classType, DependencyScope scope = DependencyScope.Transient, object singleton = null)
        {
            IRegistration registration = null;

            switch (scope)
            {
                case DependencyScope.Singleton:
                    if (singleton != null)
                    {
                        registration = Component.For(serviceType).Instance(singleton).LifestyleSingleton();
                    }
                    else
                    {
                        registration = Component.For(serviceType).ImplementedBy(classType).LifestyleSingleton();
                    }
                    break;
                case DependencyScope.PerThread:
                    registration = Component.For(serviceType).ImplementedBy(classType).LifestylePerThread();
                    break;
                case DependencyScope.PerWebRequest:
                    registration = Component.For(serviceType).LifestylePerWebRequest();
                    break;
                case DependencyScope.Transient:
                    registration = Component.For(serviceType).ImplementedBy(classType).LifestyleTransient();
                    break;
            }

            _kernel.Register(registration);
            return this;
        }

        /// <summary>
        /// Resolves and returns instance of implementation for the requested service type
        /// </summary>
        /// <param name="serviceType"></param>
        /// <returns></returns>
        public object Resolve(Type serviceType)
        {
            return _kernel.Resolve(serviceType);
        }
    }
}
