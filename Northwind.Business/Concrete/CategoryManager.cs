using AutoMapper;
using Northwind.Business.Abstract;
using Northwind.DataAccess.Abstract;
using Northwind.Dto.Category;
using Northwind.Entities.Concrete;

namespace Northwind.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;
        private readonly IMapper _mapper;
        public CategoryManager(ICategoryDal categoryDal, IMapper mapper)
        {
            _categoryDal = categoryDal;
            _mapper = mapper;
        }
        public void Add(CreateCategoryDto dto)
        {
           var entity=_mapper.Map<Category>(dto);
            _categoryDal.Add(entity);
        }

        public void Delete(int id)
        {
           var entity= _categoryDal.Get(x => x.CategoryId == id);
            if (entity == null)
            throw new Exception("Category not found");
            _categoryDal.Delete(entity);
        }

        public ResultCategoryDto? Get(int id)
        {
            var entity = _categoryDal.Get(x => x.CategoryId == id);
            if (entity == null)
                throw new Exception("Category not found");
            return _mapper.Map<ResultCategoryDto>(entity);
        }

        public List<ResultCategoryDto> GetAll()
        {
            var values = _categoryDal.GetAll();
            return _mapper.Map<List<ResultCategoryDto>>(values);
        }

        public void Update(UpdateCategoryDto dto)
        {
            var values=_mapper.Map<Category>(dto);
            _categoryDal.Update(values);
        }
    }
}
