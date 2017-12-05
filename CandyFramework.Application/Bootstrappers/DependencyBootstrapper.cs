using CandyFramework.BusinessLayer.Concrete;
using CandyFramework.BusinessLayer.Interface;
using CandyFramework.Core.Concrete.Common;
using CandyFramework.Core.Concrete.Core;
using CandyFramework.Core.Interface.Application;
using CandyFramework.Core.Interface.Core;
using CandyFramework.DataAccessLayer.Concrete.EntityFramework;
using CandyFramework.DataAccessLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyFramework.Application.Bootstrappers
{
    /// <summary>
    /// Dependency bootstrapper
    /// </summary>
    public class DependencyBootstrapper : IBootstrapper
    {
        /// <summary>
        /// Bootstraps dependencies
        /// </summary>
        /// <param name="dependencyContainer"></param>
        public virtual void Bootstrap(IDependencyContainer dependencyContainer)
        {
            //dependencyContainer.RegisterTransient<ILogger, Logger>();

            //User Table için dependency injection
            dependencyContainer.RegisterTransient<IUserService, UserService>();
            dependencyContainer.RegisterTransient<IUserRepository, UserEfRepository>();

            dependencyContainer.RegisterTransient<ISettingService, SettingService>();
            dependencyContainer.RegisterTransient<ISettingRepository, SettingEfRepository>();

            dependencyContainer.RegisterTransient<IUserGroupService, UserGroupService>();
            dependencyContainer.RegisterTransient<IUserGroupRepository, UserGroupEfRepository>();


        }
    }
}
