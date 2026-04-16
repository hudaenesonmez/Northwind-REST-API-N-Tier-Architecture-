using Northwind.Dto.Product;

namespace Northwind.Business.Abstract
{
    public interface IProductService
    {
        void Add(CreateProductDto createProductDto);
        void Update(UpdateProductDto updateProductDto);
        void Delete(int id);
        ResultProductDto? Get(int id);
        List<ResultProductDto> GetAll();
    }
}
