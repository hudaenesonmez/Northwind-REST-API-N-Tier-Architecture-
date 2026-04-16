using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Northwind.Business.Abstract;
using Northwind.DataAccess.Abstract;
using Northwind.Dto.Order;
using Northwind.Entities.Concrete;

namespace Northwind.Business.Concrete
{
    public class OrderManager : IOrderService
    {
        private readonly IOrderDal _orderDal;
        private readonly IOrderDetailDal _orderDetailDal;
        private readonly IMapper _mapper;

        public OrderManager(IOrderDal orderDal, IOrderDetailDal orderDetailDal, IMapper mapper)
        {
            _orderDal = orderDal;
            _orderDetailDal = orderDetailDal;
            _mapper = mapper;
        }
        public void Add(CreateOrderDto createOrderDto)
        {
            var entity = _mapper.Map<Order>(createOrderDto);
            _orderDal.Add(entity);
        }

      

        public ResultOrderDto Get(int id)
        {
            var value = _orderDal.Get(x=>x.OrderId==id);
            return _mapper.Map<ResultOrderDto>(value);
        }

        public List<ResultOrderDto> GetAll()
        {
            var values = _orderDal.GetAll();
            return _mapper.Map<List<ResultOrderDto>>(values);
        }

        public List<ResultOrderWithDetailDto> GetAllWithDetails()
        {
            var values = _orderDal.GetAllWithDetails();
            return _mapper.Map<List<ResultOrderWithDetailDto>>(values);
        }

        public ResultOrderWithDetailDto GetWithDetails(int id)
        {
            var value=_orderDal.GetWithDetails(id);
            return _mapper.Map<ResultOrderWithDetailDto>(value);
        }

        public void Update(UpdateOrderDto updateOrderDto)
        {
            var value=_mapper.Map<Order>(updateOrderDto);
            var entity = _orderDal.Get(x => x.OrderId == value.OrderId);
            if (value == null)
                throw new Exception("Order not found!");

            _orderDal.Update(value);
        }
    }
}
