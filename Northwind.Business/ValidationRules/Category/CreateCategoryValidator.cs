using System.Collections.Generic;
using System.ComponentModel;
using FluentValidation;
using Northwind.Dto.Category;
using Northwind.Entities.Concrete;

namespace Northwind.Business.ValidationRules.Category
{
    public class CreateCategoryValidator:AbstractValidator<CreateCategoryDto>
    {
        public CreateCategoryValidator()
        {
                RuleFor(x=>x.CategoryName)
                .NotEmpty().WithMessage("The category name field cannot be left blank")
                .MaximumLength(15).WithMessage("The category name field cannot be over 15 characters");

                RuleFor(x => x.Description)
                .MinimumLength(3).WithMessage("The category description field must contain at least 3 characters");
        }
    }
}
