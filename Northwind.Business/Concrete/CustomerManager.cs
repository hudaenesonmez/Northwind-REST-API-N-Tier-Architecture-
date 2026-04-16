using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Northwind.Business.Abstract;
using Northwind.DataAccess.Abstract;
using Northwind.Dto.Customer;
using Northwind.Entities.Concrete;

namespace Northwind.Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;
        private readonly IMapper _mapper;
        public CustomerManager(ICustomerDal customerDal, IMapper mapper)
        {
            _customerDal = customerDal;
            _mapper = mapper;
        }
        public void Add(CreateCustomerDto createCustomerDto)
        {
            var entity=_mapper.Map<Customer>(createCustomerDto);
            _customerDal.Add(entity);
        }

        public void Delete(string id)
        {
            var entity = _customerDal.Get(x => x.CustomerId == id);
            if (entity == null) throw new Exception("Customer not found");
            _customerDal.Delete(entity);
        }

        public ResultCustomerDto? Get(string id)
        {
            var entity = _customerDal.Get(x => x.CustomerId == id);
            return _mapper.Map<ResultCustomerDto>(entity);
        }

        public List<ResultCustomerDto> GetAll()
        {
            var values=_customerDal.GetAll();
            return _mapper.Map<List<ResultCustomerDto>>(values);

        }

        public void Update(UpdateCustomerDto updateCustomerDto)
        {
            var values=_mapper.Map<Customer>(updateCustomerDto);
            _customerDal.Update(values);
        }
    }
}
