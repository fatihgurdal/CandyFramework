using CandyFramework.Core.Interface.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CandyFramework.Core.Interface.DataAccess
{
    public interface IRepository<TEntity> where TEntity : class, IEntity, new()
    {
        IQueryable<TEntity> AsQueryable();
        TEntity First(Expression<Func<TEntity, bool>> where);
        TEntity Single(Expression<Func<TEntity, bool>> where);
        IQueryable<TEntity> Gets(Expression<Func<TEntity, bool>> where);
        int Count(Expression<Func<TEntity, bool>> where);
        bool Any(Expression<Func<TEntity, bool>> where);
        void Delete(TEntity entity);
        void Delete(IEnumerable<TEntity> entities);
        void Add(TEntity entity);
        void Add(List<TEntity> entities);
        void Update(TEntity entity);
        void Update(IEnumerable<TEntity> entities);
    }
}
