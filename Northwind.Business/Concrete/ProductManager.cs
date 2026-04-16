using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Northwind.Business.Abstract;
using Northwind.DataAccess.Abstract;
using Northwind.Dto.Product;
using Northwind.Entities.Concrete;

namespace Northwind.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;
        private readonly IMapper _mapper;
        public ProductManager(IMapper mapper, IProductDal productDal)
        {
            _mapper = mapper;
            _productDal = productDal;
        }
        public void Add(CreateProductDto createProductDto)
        {
            var entity=_mapper.Map<Product>(createProductDto);
            _productDal.Add(entity);
        }

        public void Delete(int id)
        {
            var entity=_productDal.Get(x=>x.ProductId == id);
            if (entity == null)
                throw new Exception("Product not found!");
            _productDal.Delete(entity);

            
        }

        public ResultProductDto? Get(int id)
        {
            var entity = _productDal.Get(x => x.ProductId == id);
            return _mapper.Map<ResultProductDto>(entity);
        }

        public List<ResultProductDto> GetAll()
        {
            var values=_productDal.GetAll();
            return _mapper.Map<List<ResultProductDto>>(values);
        }

        public void Update(UpdateProductDto updateProductDto)
        {
            var value=_mapper.Map<Product>(updateProductDto);
            _productDal.Update(value);
        }
    }
}
