using CandyFramework.Core.Interface.Entity;
using CandyFramework.Entity.Entity.Entity;
using CandyFramework.Entity.Interface.ViewModel;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyFramework.Entity.Entity.ViewModel
{
    public class SettingView : Base.Setting, ISettingView, IViewMap<SettingEntity>
    {
        public SettingView()
        {

        }
        public SettingEntity Map()
        {
            var result = this.Adapt<SettingEntity>();

            return result;
        }
    }
}
