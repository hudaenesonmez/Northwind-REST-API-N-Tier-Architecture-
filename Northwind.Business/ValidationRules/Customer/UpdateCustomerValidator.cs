using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Northwind.Dto.Customer;

namespace Northwind.Business.ValidationRules.Customer
{
    public class UpdateCustomerValidator:AbstractValidator<UpdateCustomerDto>
    {
        public UpdateCustomerValidator()
        {
            RuleFor(x => x.CustomerId).NotEmpty().WithMessage("The customer id field cannot be left blank")
               .MaximumLength(5).WithMessage("The customer id field cannot be over 5 characters");

            RuleFor(x => x.CompanyName).NotEmpty().WithMessage("The company name field cannot be left blank")
                .MaximumLength(40).WithMessage("The company name field cannot be over 40 characters");

            RuleFor(x => x.CompanyName)
                .MaximumLength(30).WithMessage("The contact name field cannot be over 30 characters");

            RuleFor(x => x.ContactTitle)
                .MaximumLength(30).WithMessage("The contact title field cannot be over 30 characters");

            RuleFor(x => x.Address)
                .MaximumLength(60).WithMessage("The address field cannot be over 60 characters");

            RuleFor(x => x.City)
                .MaximumLength(15).WithMessage("The city field cannot be over 15 characters");

            RuleFor(x => x.Region)
                .MaximumLength(15).WithMessage("The region field cannot be over 15 characters");

            RuleFor(x => x.PostalCode)
                .MaximumLength(10).WithMessage("The postal code field cannot be over 10 characters");

            RuleFor(x => x.Country)
                .MaximumLength(15).WithMessage("The country field cannot be over 15 characters");

            RuleFor(x => x.Phone)
                .MaximumLength(24).WithMessage("The phone field cannot be over 24 characters");

            RuleFor(x => x.Fax)
                .MaximumLength(24).WithMessage("The fax field cannot be over 24 characters");
        }
    }
}
