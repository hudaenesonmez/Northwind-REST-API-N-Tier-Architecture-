using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.Dto.Customer;

namespace Northwind.Business.Abstract
{
    public interface ICustomerService
    {
        public void Add(CreateCustomerDto createCustomerDto);
        public void Update(UpdateCustomerDto updateCustomerDto);
        public void Delete(string id);
        ResultCustomerDto? Get(string id);
        List<ResultCustomerDto> GetAll();
    }
}
