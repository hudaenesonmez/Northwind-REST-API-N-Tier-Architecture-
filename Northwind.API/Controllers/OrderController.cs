using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Northwind.Business.Abstract;
using Northwind.Dto.Order;

namespace Northwind.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        [HttpGet("[action]")]
        public IActionResult GetOrdersWithDetails()
        {
            var result=_orderService.GetAllWithDetails();
            return Ok(result);
        }
        [HttpGet("[action]")]
        public IActionResult GetOrderWithDetails(int id)
        {
            var result = _orderService.GetWithDetails(id);
            return Ok(result);
        }
        [HttpGet("[action]")]
        public IActionResult GetOrders()
        {
            var result = _orderService.GetAll();
            return Ok(result);
        }
        [HttpGet("[action]")]
        public IActionResult GetOrder(int id)
        {
            var result = _orderService.Get(id);
            return Ok(result);
        }
        [HttpPost("[action]")]
        public IActionResult AddOrder(CreateOrderDto dto)
        {
            _orderService.Add(dto);
            return Ok();
        }
        [HttpPut("[action]")]
        public IActionResult UpdateOrder(UpdateOrderDto dto)
        {
            
                _orderService.Update(dto);
                return Ok();
        }
      
    }
}
