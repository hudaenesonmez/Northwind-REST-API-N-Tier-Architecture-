using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Context;
using Northwind.Entities.Concrete;

namespace Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfSupplierDal:EfGenericRepositoryBase<Supplier>,ISupplierDal
    {
        public EfSupplierDal(NorthwindContext context) : base(context)
        {
        }
    }
}
