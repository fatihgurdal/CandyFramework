using CandyFramework.Core.Interface.DataAccess;
using CandyFramework.Core.Interface.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CandyFramework.DataAccessLayer.Concrete.EntityFramework.Base
{
    public abstract class EntityFrameworkRepository<TEntity, TContext> : IDisposable, IRepository<TEntity> where TEntity : class, IEntity, new() where TContext : DbContext, new()
    {
        public TContext _context { get; private set; }

        internal EntityFrameworkRepository()
        {
            _context = new TContext();
        }
        public IQueryable<TEntity> AsQueryable()
        {
            return _context.Set<TEntity>();
        }

        public TEntity First(Expression<Func<TEntity, bool>> @where)
        {
            return _context.Set<TEntity>().FirstOrDefault(where);
        }
        public TEntity Single(Expression<Func<TEntity, bool>> @where)
        {
            return _context.Set<TEntity>().SingleOrDefault(where);
        }
        public IQueryable<TEntity> Gets(Expression<Func<TEntity, bool>> @where)
        {
            return _context.Set<TEntity>().Where(where);
        }

        public int Count(Expression<Func<TEntity, bool>> @where)
        {
            return _context.Set<TEntity>().Count(where);
        }

        public bool Any(Expression<Func<TEntity, bool>> @where)
        {
            return _context.Set<TEntity>().Any(where);
        }

        public void Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
            _context.SaveChanges();
        }

        public void Delete(IEnumerable<TEntity> entities)
        {
            _context.Set<TEntity>().RemoveRange(entities);
            _context.SaveChanges();
        }

        public void Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();
        }

        public void Add(List<TEntity> entities)
        {
            _context.Set<TEntity>().AddRange(entities);
            _context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            var updatedObject = _context.Entry(entity);
            updatedObject.State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Update(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                var updatedObject = _context.Entry(entity);
                updatedObject.State = EntityState.Modified;
            }
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
