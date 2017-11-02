using CandyFramework.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyFramework.Core.Interface.Application
{
    /// <summary>
    /// The IoC container interface
    /// </summary>
    public interface IDependencyContainer
    {
        /// <summary>
        /// Registers a service implementation for the given  service type withe given scope
        /// </summary>
        /// <param name="serviceType">The service type</param>
        /// <param name="classType">The service implementation type</param>
        /// <param name="scope">Scope of registration</param>
        /// <param name="singleton">Singleton instance if scope is singleton</param>
        /// <returns></returns>
        IDependencyContainer Register(Type serviceType, Type classType, DependencyScope scope = DependencyScope.Transient, object singleton = null);

        /// <summary>
        /// Resolves and returns instance of implementation for the requested service type
        /// </summary>
        /// <param name="serviceType"></param>
        /// <returns></returns>
        object Resolve(Type serviceType);
    }
}
