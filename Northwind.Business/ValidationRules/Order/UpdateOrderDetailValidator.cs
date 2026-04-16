using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Northwind.Dto.Order;

namespace Northwind.Business.ValidationRules.Order
{
    public class UpdateOrderDetailValidator:AbstractValidator<UpdateOrderDetailDto>
    {
        public UpdateOrderDetailValidator()
        {
            RuleFor(x=>x.OrderId).NotEmpty().WithMessage("The order id field cannot be left blank");
            RuleFor(x => x.ProductId).NotEmpty().WithMessage("The product id field cannot be left blank");
            RuleFor(x => x.UnitPrice).NotEmpty().WithMessage("The product id field cannot be left blank");
            RuleFor(x => x.Quantity).NotEmpty().WithMessage("The product id field cannot be left blank");
            RuleFor(x => x.Discount).NotEmpty().WithMessage("The product id field cannot be left blank");
        }
    }
}
