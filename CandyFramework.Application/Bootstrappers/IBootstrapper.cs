using CandyFramework.Core.Interface.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyFramework.Application.Bootstrappers
{
    /// <summary>
    /// Bootstrapper interface
    /// </summary>
    public interface IBootstrapper
    {
        /// <summary>
        /// Bootstraps and/or registersters dependencies using the given dependency container
        /// </summary>
        /// <param name="dependencyContainer"></param>
        void Bootstrap(IDependencyContainer dependencyContainer);
    }
}
