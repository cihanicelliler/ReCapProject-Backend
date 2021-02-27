using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules
{
    public class CustomerValidator : AbstractValidator<Customers>
    {
        public CustomerValidator()
        {

        }
    }
}
