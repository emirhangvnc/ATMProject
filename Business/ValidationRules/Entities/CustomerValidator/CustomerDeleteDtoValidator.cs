using BusinessLayer.Constants.TR;
using BusinessLayer.Constants.TR.Base;
using EntitiesLayer.DTOs.CustomerDTO;
using FluentValidation;

namespace BusinessLayer.ValidationRules.Entities.CustomerValidator
{
    public class CustomerDeleteDtoValidator : AbstractValidator<CustomerDeleteDto>
    {
        public CustomerDeleteDtoValidator()
        {
            RuleFor(c => c.Id).NotEmpty().WithMessage($"{BaseConstantsTR.ID} {BaseConstantsTR.NotNull}");
        }
    }
}