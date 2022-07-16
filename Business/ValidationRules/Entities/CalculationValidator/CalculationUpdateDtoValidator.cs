using BusinessLayer.Constants.TR;
using BusinessLayer.Constants.TR.Base;
using EntitiesLayer.DTOs.CalculationDTO;
using FluentValidation;

namespace BusinessLayer.ValidationRules.Entities.CityValidator
{
    public class CalculationUpdateDtoValidator : AbstractValidator<CalculationUpdateDto>
    {
        public CalculationUpdateDtoValidator()
        {
            RuleFor(c => c.Id).NotEmpty().WithMessage($"{CalculationMessagesTR.Calculation} {BaseConstantsTR.ID} {BaseConstantsTR.NotNull}");
            RuleFor(c => c.CustomerId).NotEmpty().WithMessage($"{CustomerMessagesTR.Customer} {BaseConstantsTR.ID} {BaseConstantsTR.NotNull}");
        }
    }
}