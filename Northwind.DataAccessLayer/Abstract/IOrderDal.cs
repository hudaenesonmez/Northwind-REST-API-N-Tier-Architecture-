using Northwind.Entities.Concrete;

namespace Northwind.DataAccess.Abstract
{
    public interface IOrderDal:IGenericDal<Order>
    {
        Order GetWithDetails(int id);
        List<Order> GetAllWithDetails();
       

    }
}
