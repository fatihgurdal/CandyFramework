using CandyFramework.BusinessLayer.Interface;
using CandyFramework.DataAccessLayer.Interface;
using CandyFramework.Entity.Entity.Entity;
using CandyFramework.Entity.Entity.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyFramework.BusinessLayer.Concrete
{
    public class UserGroupService: BaseService<UserGroupEntity, UserGroupView>, IUserGroupService
    {
        #region - Repository -
        private readonly IUserGroupRepository UserGroupRepository;
        #endregion
        public UserGroupService(IUserGroupRepository _UserGroupRepository) : base(_UserGroupRepository)
        {
            UserGroupRepository = _UserGroupRepository;
        }
    }
}
