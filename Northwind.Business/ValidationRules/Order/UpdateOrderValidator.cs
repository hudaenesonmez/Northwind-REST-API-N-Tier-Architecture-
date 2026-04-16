using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Northwind.Dto.Order;

namespace Northwind.Business.ValidationRules.Order
{
    public class UpdateOrderValidator:AbstractValidator<UpdateOrderDto>
    {
        public UpdateOrderValidator()
        {
            RuleFor(x=>x.OrderId).NotEmpty().WithMessage("The order id field cannot be left blank");
            RuleFor(x => x.CustomerId).MaximumLength(5).WithMessage("The customer id field cannot be over 5 characters");
            RuleFor(x => x.ShipName).MaximumLength(40).WithMessage("The ship name field cannot be over 40 characters");
            RuleFor(x => x.ShipAddress).MaximumLength(60).WithMessage("The ship address field cannot be over 60 characters");
            RuleFor(x => x.ShipCity).MaximumLength(15).WithMessage("The ship city field cannot be over 15 characters");
            RuleFor(x => x.ShipRegion).MaximumLength(15).WithMessage("The ship region field cannot be over 15 characters");
            RuleFor(x => x.ShipPostalCode).MaximumLength(10).WithMessage("The ship postal code field cannot be over 10 characters");
            RuleFor(x => x.ShipCountry).MaximumLength(15).WithMessage("The ship country field cannot be over 15 characters");
        }
       
    }
}
