using Microsoft.AspNetCore.Mvc;

using Northwind.Business.Abstract;
using Northwind.Dto.Category;

namespace Northwind.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
                _categoryService = categoryService;
        }
        [HttpGet("[action]")]
        public IActionResult GetAll()
        {
           var result= _categoryService.GetAll();
            return Ok(result);
        }
        [HttpPost("[action]")]
        public IActionResult AddCategory(CreateCategoryDto dto)
        {
            _categoryService.Add(dto);
            return Ok();
        }
        [HttpPut("[action]")]
        public IActionResult UpdateCategory(UpdateCategoryDto dto)
        {
            _categoryService.Update(dto);
            return Ok();
        }
        [HttpGet("[action]")]
        public IActionResult GetCategory(int id)
        {
            var result=_categoryService.Get(id);
            return Ok(result);
        }
        [HttpDelete("[action]")]
        public IActionResult DeleteCategory(int id)
        {
            _categoryService.Delete(id);
            return Ok();
        }
    }
}
