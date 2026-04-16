using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Context;
using Northwind.Entities.Concrete;

namespace Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal:EfGenericRepositoryBase<Product>,IProductDal
    {
        public EfProductDal(NorthwindContext context) : base(context)
        {
        }
    }
}
