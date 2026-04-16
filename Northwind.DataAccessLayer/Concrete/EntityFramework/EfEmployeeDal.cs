using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Context;
using Northwind.Entities.Concrete;

namespace Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfEmployeeDal:EfGenericRepositoryBase<Employee>,IEmployeeDal
    {
        public EfEmployeeDal(NorthwindContext context) : base(context)
        {
        }
    }
}
