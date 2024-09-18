using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi24.Core.Common;
using Taxi24.Core.Dto;

namespace Taxi24.Core.Validator
{
   

    public class RegisterDriverValidator : AbstractValidator<RegisterDriverDto>
    {
        public RegisterDriverValidator()
        {
            RuleFor(x => x.Name).NotNull().WithMessage(ErrorMessages.NameRequired);
            RuleFor(x => x.IdentityNumber).NotNull().WithMessage(ErrorMessages.IdentityNumberRequired);
            RuleFor(x => x.UserName).NotNull().WithMessage(ErrorMessages.PhoneNumberRequired);
            RuleFor(x => x.DateOfBirth).NotNull().WithMessage(ErrorMessages.DateOfBirth);
          
        }
    }
}
