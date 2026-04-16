using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Context;
using Northwind.Entities.Concrete;

namespace Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDemographicDal:EfGenericRepositoryBase<CustomerDemographic>,ICustomerDemographicDal
    {
        public EfCustomerDemographicDal(NorthwindContext context) : base(context)
        {
        }
    }
}
