using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Context;
using Northwind.Entities.Concrete;

namespace Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfTerritoryDal:EfGenericRepositoryBase<Territory>,ITerritoryDal
    {
        public EfTerritoryDal(NorthwindContext context) : base(context)
        {
        }
    }
}
