using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Context;
using Northwind.Entities.Concrete;

namespace Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal:EfGenericRepositoryBase<Customer>,ICustomerDal
    {
        public EfCustomerDal(NorthwindContext context) : base(context)
        {
        }
    }
}
