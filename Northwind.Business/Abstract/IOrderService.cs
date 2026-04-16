using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.Dto.Order;
using Northwind.Entities.Concrete;

namespace Northwind.Business.Abstract
{
    public interface IOrderService
    {
        public void Add(CreateOrderDto createOrderDto);
        public void Update(UpdateOrderDto updateOrderDto);
       
        public ResultOrderDto Get(int id);
        ResultOrderWithDetailDto GetWithDetails(int id);
        public List<ResultOrderDto> GetAll();
        public List<ResultOrderWithDetailDto> GetAllWithDetails();
    }
}
