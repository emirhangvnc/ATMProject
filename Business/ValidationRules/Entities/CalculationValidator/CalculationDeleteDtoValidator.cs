using BusinessLayer.Constants.TR;
using BusinessLayer.Constants.TR.Base;
using EntitiesLayer.DTOs.CalculationDTO;
using FluentValidation;

namespace BusinessLayer.ValidationRules.Entities.CityValidator
{
    public class CalculationDeleteDtoValidator : AbstractValidator<CalculationDeleteDto>
    {
        public CalculationDeleteDtoValidator()
        {
            RuleFor(c => c.Id).NotEmpty().WithMessage($"{CalculationMessagesTR.Calculation} {BaseConstantsTR.ID} {BaseConstantsTR.NotNull}");
        }
    }
}