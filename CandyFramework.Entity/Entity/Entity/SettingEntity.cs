using CandyFramework.Core.Interface.Entity;
using CandyFramework.Entity.Entity.ViewModel;
using CandyFramework.Entity.Interface.Entity;
using Mapster;
using System;

namespace CandyFramework.Entity.Entity.Entity
{
    public class SettingEntity : Base.Setting, ISettingEntity, IEntityMap<SettingView>
    {
        public string CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime UpdateDate { get; set; }

        public SettingEntity()
        {

        }
        public SettingView Map()
        {
            var result = this.Adapt<SettingView>();

            return result;
        }
    }
}
