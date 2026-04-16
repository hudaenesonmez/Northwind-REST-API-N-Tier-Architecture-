using Microsoft.EntityFrameworkCore;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Context;
using Northwind.Entities.Concrete;

namespace Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfOrderDal : EfGenericRepositoryBase<Order>, IOrderDal
    {
        public EfOrderDal(NorthwindContext context) : base(context)
        {
        }
        public List<Order> GetAllWithDetails()
        {
            
                return _context.Orders
                    .Include(x => x.OrderDetails)
                    .ToList();
            
        }
        public Order GetWithDetails(int id)
        {
            
                return _context.Orders
                    .Include(x => x.OrderDetails)
                    .FirstOrDefault(x => x.OrderId == id);
            
        }
    }
}
