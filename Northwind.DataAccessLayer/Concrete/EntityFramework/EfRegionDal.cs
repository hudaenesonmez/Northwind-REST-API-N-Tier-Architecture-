using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Context;
using Northwind.Entities.Concrete;

namespace Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfRegionDal:EfGenericRepositoryBase<Region>,IRegionDal
    {
        public EfRegionDal(NorthwindContext context) : base(context)
        {
        }
    }
}
