using Northwind.Dto.Category;


namespace Northwind.Business.Abstract
{
    public interface ICategoryService
    {
        void Add(CreateCategoryDto createCategoryDto);
        void Update(UpdateCategoryDto updateCategoryDto);
        void Delete(int id);
        ResultCategoryDto? Get(int id);
        List<ResultCategoryDto> GetAll();
    }
}
