using CandyFramework.BusinessLayer.Concrete;
using CandyFramework.BusinessLayer.Interface;
using CandyFramework.Core.Concrete.Common;
using CandyFramework.Core.Interface.Application;
using CandyFramework.DataAccessLayer.Concrete.EntityFramework;
using CandyFramework.DataAccessLayer.Interface;

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
            //User Table for dependency injection
            dependencyContainer.RegisterTransient<IUserService, UserService>();
            dependencyContainer.RegisterTransient<IUserRepository, UserEfRepository>();

            //Setting Table for dependency injection
            dependencyContainer.RegisterTransient<ISettingService, SettingService>();
            dependencyContainer.RegisterTransient<ISettingRepository, SettingEfRepository>();

            //UserGroup Table for dependency injection
            dependencyContainer.RegisterTransient<IUserGroupService, UserGroupService>();
            dependencyContainer.RegisterTransient<IUserGroupRepository, UserGroupEfRepository>();
        }
    }
}
