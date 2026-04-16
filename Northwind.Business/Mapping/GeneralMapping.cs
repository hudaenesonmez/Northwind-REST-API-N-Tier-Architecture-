using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Northwind.Dto.Category;
using Northwind.Dto.Customer;
using Northwind.Dto.Order;
using Northwind.Dto.Product;
using Northwind.Entities.Concrete;

namespace Northwind.Business.Mapping
{
    public class GeneralMapping:Profile
    {
        public GeneralMapping()
        {
            //Category
            CreateMap<CreateCategoryDto, Category>();   
            CreateMap<ResultCategoryDto,Category>().ReverseMap();
            CreateMap<UpdateCategoryDto, Category>();

            //Customer
            CreateMap<CreateCustomerDto, Customer>();
            CreateMap<ResultCustomerDto, Customer>().ReverseMap();
            CreateMap<UpdateCustomerDto, Customer>();

            //Order-OrderDetails
            CreateMap<ResultOrderDto, Order>().ReverseMap(); 
            CreateMap<ResultOrderDetailDto, OrderDetail>().ReverseMap();
            CreateMap<ResultOrderWithDetailDto,Order>().ForMember(x=>x.OrderDetails,y=>y.MapFrom(x=>x.OrderDetails)).ReverseMap();
            CreateMap<CreateOrderDetailDto, OrderDetail>();
            CreateMap<CreateOrderDto, Order>();
            CreateMap<UpdateOrderDetailDto, OrderDetail>();
            CreateMap<UpdateOrderDto, Order>();

            //Product
            CreateMap<ResultProductDto, Product>().ReverseMap();
            CreateMap<CreateProductDto,Product>();
            CreateMap<UpdateProductDto, Product>();

        }
    }
}
