using System.Linq.Expressions;

namespace Northwind.DataAccess.Abstract
{
    public interface IGenericDal<T>
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T? Get(Expression<Func<T,bool>>filter);
        List<T> GetAll(Expression<Func<T,bool>>filter=null);
    }
}
