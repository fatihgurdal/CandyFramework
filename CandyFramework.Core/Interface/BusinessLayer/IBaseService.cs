using System.Collections.Generic;

namespace CandyFramework.Core.Interface.BusinessLayer
{
    public interface IBaseService<TView>
    {
        List<TView> All();
        void Delete(TView entity);
        void Delete(IEnumerable<TView> entities);
        void Add(TView entity);
        void Add(List<TView> entities);
        void Update(TView entity);
        void Update(IEnumerable<TView> entities);
    }
}
