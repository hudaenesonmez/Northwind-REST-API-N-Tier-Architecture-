using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Northwind.Dto.Order;

namespace Northwind.Business.ValidationRules.Order
{
    public class CreateOrderDetailValidator:AbstractValidator<CreateOrderDetailDto>
    {
        public CreateOrderDetailValidator()
        {
                RuleFor(x=>x.ProductId).NotEmpty().WithMessage("The product id field cannot be left blank");
                RuleFor(x => x.UnitPrice).NotEmpty().WithMessage("The product id field cannot be left blank");
                RuleFor(x => x.Quantity).NotEmpty().WithMessage("The product id field cannot be left blank");
                RuleFor(x => x.Discount).NotEmpty().WithMessage("The product id field cannot be left blank");
        }
    }
}
