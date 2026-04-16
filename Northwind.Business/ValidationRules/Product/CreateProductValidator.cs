using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Northwind.Dto.Product;

namespace Northwind.Business.ValidationRules.Product
{
    public class CreateProductValidator:AbstractValidator<CreateProductDto>
    {
        public CreateProductValidator()
        {
                RuleFor(x=>x.ProductName).NotEmpty().WithMessage("The product name field cannot be left blank")
                .MaximumLength(40).WithMessage("The product name field cannot be over 40 characters");

            RuleFor(x => x.QuantityPerUnit).MaximumLength(20).WithMessage("The quantity per unit field cannot be over 20 characters");
            RuleFor(x => x.Discontinued).NotNull().WithMessage("The discontinued field cannot be left blank");
        }
    }
}
