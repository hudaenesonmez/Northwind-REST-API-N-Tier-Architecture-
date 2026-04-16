using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Northwind.Dto.Category;

namespace Northwind.Business.ValidationRules.Category
{
    public class UpdateCategoryValidator:AbstractValidator<UpdateCategoryDto>
    {
        public UpdateCategoryValidator()
        {
                RuleFor(x=>x.CategoryId).NotEmpty().WithMessage("Id girişi zorunludur.");
                RuleFor(x => x.CategoryName)
                .NotEmpty().WithMessage("The category name field cannot be left blank")
                .MaximumLength(15).WithMessage("The category name field cannot be over 15 characters")
                 .When(x => x.CategoryName != null); ;

                RuleFor(x => x.Description)
               .MinimumLength(3).WithMessage("The category description field must contain at least 3 characters")
                 .When(x => x.Description != null); ;
        }
    }
}
