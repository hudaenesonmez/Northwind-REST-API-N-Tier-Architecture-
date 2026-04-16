using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Northwind.Business.Abstract;
using Northwind.Dto.Product;

namespace Northwind.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet("[action]")]
        public IActionResult GetProducts()
        {
            var result = _productService.GetAll();
            return Ok(result);
        }
        [HttpGet("[action]")]
        public IActionResult GetProduct(int id)
        {
            var result = _productService.Get(id);
            return Ok(result);
        }
        [HttpPost("[action]")]
        public IActionResult AddProduct(CreateProductDto createProductDto)
        {
            _productService.Add(createProductDto);
            return Ok();
        }
        [HttpPut("[action]")]
        public IActionResult UpdateProduct(UpdateProductDto updateProductDto)
        {
            _productService.Update(updateProductDto);
            return Ok();
        }
        [HttpDelete("[action]")]
        public IActionResult DeleteProduct(int id)
        {
            ;_productService.Delete(id);
            return Ok();
        }
    }
}
