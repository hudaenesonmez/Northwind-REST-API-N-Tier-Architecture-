using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Context;
using Northwind.Entities.Concrete;

namespace Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal:EfGenericRepositoryBase<Category>,ICategoryDal
    {
        public EfCategoryDal(NorthwindContext context) : base(context)
        {
        }
    }
}
