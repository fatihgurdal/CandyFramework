using CandyFramework.Core.Interface.Entity;
using CandyFramework.Entity.Entity.Base;
using CandyFramework.Entity.Entity.ViewModel;
using Mapster;

namespace CandyFramework.Entity.Entity.Entity
{
    public class CandyLogEntity : CandyLog, IEntityMap<CandyLogView>
    {

        #region - Entity Map -
        public CandyLogView Map()
        {
            var result = this.Adapt<CandyLogView>();
            return result;
        } 
        #endregion
    }
}
