using BusinessLayer.Constants.TR;
using BusinessLayer.Constants.TR.Base;
using EntitiesLayer.DTOs.CalculationDTO;
using FluentValidation;

namespace BusinessLayer.ValidationRules.Entities.CityValidator
{
    public class CalculationAddDtoValidator : AbstractValidator<CalculationAddDto>
    {
        public CalculationAddDtoValidator()
        {
            RuleFor(c => c.CustomerId).NotEmpty().WithMessage($"{CustomerMessagesTR.Customer} {BaseConstantsTR.ID} {BaseConstantsTR.NotNull}");
        }
    }
}