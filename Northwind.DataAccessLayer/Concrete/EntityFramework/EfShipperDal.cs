using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Context;
using Northwind.Entities.Concrete;

namespace Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfShipperDal:EfGenericRepositoryBase<Shipper>,IShipperDal
    {
        public EfShipperDal(NorthwindContext context):base(context)
        {
                
        }
    }
}
