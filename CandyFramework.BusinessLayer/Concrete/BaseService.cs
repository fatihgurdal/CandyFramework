using CandyFramework.Core.Interface.DataAccess;
using CandyFramework.Core.Interface.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using CandyFramework.Core.Interface.BusinessLayer;

namespace CandyFramework.BusinessLayer.Concrete
{
    public abstract class BaseService<TEntity, TView> : IBaseService<TView>
        where TEntity : class, IEntity, IEntityMap<TView>
        where TView : class, IViewMap<TEntity>
    {
        private readonly IRepository<TEntity> _repository;
        public BaseService(IRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public virtual void Add(TView entity)
        {
            _repository.Add(entity.Map());
        }

        public virtual void Add(List<TView> entities)
        {
            _repository.Add(entities.Select(x => x.Map()).ToList());
        }

        public virtual List<TView> All()
        {

            var list = _repository.AsQueryable().ToList();
            return list.Select(x => x.Map()).ToList();
        }

        public virtual void Delete(TView entity)
        {
            _repository.Delete(entity.Map());
        }

        public virtual void Delete(IEnumerable<TView> entities)
        {
            _repository.Delete(entities.Select(x => x.Map()));
        }

        public virtual void Update(TView entity)
        {
            _repository.Update(entity.Map());
        }

        public virtual void Update(IEnumerable<TView> entities)
        {
            _repository.Update(entities.Select(x => x.Map()));
        }
    }
}
