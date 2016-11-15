using KoperasiProject.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoperasiProject.Repository
{
    public class GenericRepository<T> : 
        IGenericRepository<T> where T : class
    {
        public KoperasiDbContext _entities;
        public GenericRepository(KoperasiDbContext entities)
        {
            _entities = entities;
        }
        public virtual IQueryable<T> GetAll()
        {

            IQueryable<T> query = _entities.Set<T>();
            return query;
        }
        public IQueryable<T> FindBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {

            IQueryable<T> query = _entities.Set<T>().Where(predicate);
            return query;
        }
        public virtual void Add(T entity)
        {
            _entities.Set<T>().Add(entity);
        }
        public virtual void Delete(T entity)
        {
            _entities.Set<T>().Remove(entity);
        }
        public virtual void Edit(T entity)
        {
            _entities.Entry(entity).State = EntityState.Modified;
        }
        public virtual void Save()
        {
            _entities.SaveChanges();
        }
    }
}
