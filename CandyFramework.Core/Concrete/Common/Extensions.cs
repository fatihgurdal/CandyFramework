using CandyFramework.Core.Enum;
using CandyFramework.Core.Interface.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyFramework.Core.Concrete.Common
{
    public static class Extensions
    {
        /// <summary>
        /// Registers a trasient service implementation for the given  types
        /// </summary>
        /// <typeparam name="TInterface"></typeparam>
        /// <typeparam name="TClass"></typeparam>
        /// <param name="prov"></param>
        /// <returns></returns>
        public static IDependencyContainer RegisterTransient<TInterface, TClass>(this IDependencyContainer prov)
            where TClass : class, TInterface
        {
            return prov.Register(typeof(TInterface), typeof(TClass));
        }

        /// <summary>
        /// Registers a per thread service implementation for the given  types
        /// </summary>
        /// <typeparam name="TInterface"></typeparam>
        /// <typeparam name="TClass"></typeparam>
        /// <param name="prov"></param>
        /// <returns></returns>
        public static IDependencyContainer RegisterPerThread<TInterface, TClass>(this IDependencyContainer prov)
            where TClass : class, TInterface
        {
            return prov.Register(typeof(TInterface), typeof(TClass), DependencyScope.PerThread);
        }

        /// <summary>
        /// Registers a per web request service implementation for the given  types
        /// </summary>
        /// <typeparam name="TInterface"></typeparam>
        /// <typeparam name="TClass"></typeparam>
        /// <param name="prov"></param>
        /// <returns></returns>
        public static IDependencyContainer RegisterPerWebRequest<TInterface, TClass>(this IDependencyContainer prov)
            where TClass : class, TInterface
        {
            return prov.Register(typeof(TInterface), typeof(TClass), DependencyScope.PerWebRequest);
        }

        /// <summary>
        /// Registers a singleton service implementation for the given  types
        /// </summary>
        /// <typeparam name="TInterface"></typeparam>
        /// <typeparam name="TClass"></typeparam>
        /// <param name="prov"></param>
        /// <returns></returns>
        public static IDependencyContainer RegisterSingleton<TInterface, TClass>(this IDependencyContainer prov)
            where TClass : class, TInterface
        {
            return prov.Register(typeof(TInterface), typeof(TClass), DependencyScope.Singleton);
        }

        /// <summary>
        /// Registers a singleton service implementation for the given type withe given instance
        /// </summary>
        /// <typeparam name="TInterface"></typeparam>
        /// <param name="prov"></param>
        /// <param name="singleton"></param>
        /// <returns></returns>
        public static IDependencyContainer RegisterSingleton<TInterface>(this IDependencyContainer prov, TInterface singleton)
        {
            return prov.Register(typeof(TInterface), singleton.GetType(), DependencyScope.Singleton, singleton);
        }

        /// <summary>
        /// Resolves and casts service implementation
        /// </summary>
        /// <typeparam name="TInterface"></typeparam>
        /// <param name="prov"></param>
        /// <returns></returns>
        public static TInterface Resolve<TInterface>(this IDependencyContainer prov)
        {
            return (TInterface)prov.Resolve(typeof(TInterface));
        }
    }
}
