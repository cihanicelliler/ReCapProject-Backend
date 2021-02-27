using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarImagesValidator : AbstractValidator<CarImages>
    {
        public CarImagesValidator()
        {
            RuleFor(c => c.CarId).NotEmpty();
            RuleFor(c => c.CarId).NotNull();
            RuleFor(c => c.Id).NotNull();
        }
    }
}
