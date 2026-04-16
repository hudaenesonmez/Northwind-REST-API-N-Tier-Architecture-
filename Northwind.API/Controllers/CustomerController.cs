using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Northwind.Business.Abstract;
using Northwind.Dto.Category;
using Northwind.Dto.Customer;

namespace Northwind.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        [HttpGet("[action]")]
        public IActionResult GetAll()
        {
            var result = _customerService.GetAll();
            return Ok(result);
        }
        [HttpPost("[action]")]
        public IActionResult AddCategory(CreateCustomerDto dto)
        {
            _customerService.Add(dto);
            return Ok();
        }
        [HttpPut("[action]")]
        public IActionResult UpdateCategory(UpdateCustomerDto dto)
        {
            _customerService.Update(dto);
            return Ok();
        }
        [HttpGet("[action]")]
        public IActionResult GetCategory(string id)
        {
            var result = _customerService.Get(id);
            return Ok(result);
        }
        [HttpDelete("[action]")]
        public IActionResult DeleteCategory(string id)
        {
            _customerService.Delete(id);
            return Ok();
        }
    }
}
