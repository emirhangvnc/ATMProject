using BusinessLayer.Constants.TR;
using BusinessLayer.Constants.TR.Base;
using EntitiesLayer.DTOs.CustomerDTO;
using FluentValidation;

namespace BusinessLayer.ValidationRules.Entities.CustomerValidator
{
    public class CustomerUpdateDtoValidator : AbstractValidator<CustomerUpdateDto>
    {
        public CustomerUpdateDtoValidator()
        {
            RuleFor(c => c.Id).NotEmpty().WithMessage($"{BaseConstantsTR.ID} {BaseConstantsTR.NotNull}");
            RuleFor(c => c.CustomerId).NotEmpty().WithMessage($"{CustomerMessagesTR.Customer} {BaseConstantsTR.ID} {BaseConstantsTR.NotNull}");
        }
    }
}