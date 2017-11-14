using CandyFramework.BusinessLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CandyFramework.Entity.Entity.ViewModel;
using CandyFramework.DataAccessLayer.Interface;
using CandyFramework.Entity.Entity.Entity;

namespace CandyFramework.BusinessLayer.Concrete
{
    public class SettingService : BaseService<SettingEntity, SettingView>, ISettingService
    {
        #region - Repository -
        private readonly ISettingRepository settingRepository;
        #endregion
        public SettingService(ISettingRepository _settingRepository) : base(_settingRepository)
        {
            settingRepository = _settingRepository;
        }
        
    }
}
