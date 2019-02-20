﻿using DemoCore.Domain.Commands;
using FluentValidation;

namespace DemoCore.Domain.Validations
{
    public class DeveloperValidation<T>: AbstractValidator<T> where T: DeveloperCommand
    {
        protected void ValidateDeveloper()
        {
            RuleFor(x => x.DescriptionEN).NotEmpty().WithMessage("{PropertyName} is required.");
            RuleFor(x => x.DescriptionPT).NotEmpty().WithMessage("{PropertyName} is required.");
        }

        protected void ValidateRemove()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("{PropertyName} is required.");
        }
    }
}
