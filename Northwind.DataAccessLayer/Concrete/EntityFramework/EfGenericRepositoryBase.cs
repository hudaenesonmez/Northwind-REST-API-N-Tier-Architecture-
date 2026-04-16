using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Context;

namespace Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfGenericRepositoryBase<T> : IGenericDal<T> where T : class
    {
        protected readonly NorthwindContext _context;

        public EfGenericRepositoryBase(NorthwindContext context)
        {
            _context = context;
        }
        public void Add(T entity)
        {
           
                _context.Set<T>().Add(entity);
                _context.SaveChanges();
            
        }

        public void Delete(T entity)
        {
            
                _context.Set<T>().Remove(entity);
                _context.SaveChanges();
            
        }

        public T? Get(Expression<Func<T, bool>> filter)
        {
            
                return _context.Set<T>().AsNoTracking().FirstOrDefault(filter);
                
            
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            
                var query = _context.Set<T>().AsQueryable();
                if (filter!=null)
                {
                    query = query.Where(filter);
                }
                return query.AsNoTracking().ToList();
            
        }

        public void Update(T entity)
        {
           
                _context.Set<T>().Update(entity);
                _context.SaveChanges();
            
        }
    }
}
