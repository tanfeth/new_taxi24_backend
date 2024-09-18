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
   

    public class RegisterCarValidator : AbstractValidator<RegisterCarDto>
    {
        public RegisterCarValidator()
        {
            RuleFor(x => x.PlateNumber).NotNull().WithMessage(ErrorMessages.PlateNumberIsRequired);
            RuleFor(x => x.PlateLetterRight).NotNull().WithMessage(ErrorMessages.PlateRightLetterRequired);
            RuleFor(x => x.PlateLetterMiddle).NotNull().WithMessage(ErrorMessages.PlateMiddleLetterRequired);
            RuleFor(x => x.PlateLetterLeft).NotNull().WithMessage(ErrorMessages.PlateLeftLetterRequired);
            RuleFor(x => x.CarModelId).NotNull().WithMessage(ErrorMessages.CarModelRequired);
            RuleFor(x => x.CarTypeId).NotNull().WithMessage(ErrorMessages.CarTypeRequired);
            RuleFor(x => x.PlateType).NotNull().WithMessage(ErrorMessages.PlateTypeRequired);
          
        }
    }
}
