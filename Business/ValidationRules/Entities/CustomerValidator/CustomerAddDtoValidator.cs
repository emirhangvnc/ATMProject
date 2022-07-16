using BusinessLayer.Constants.TR;
using BusinessLayer.Constants.TR.Base;
using EntitiesLayer.DTOs.CustomerDTO;
using FluentValidation;

namespace BusinessLayer.ValidationRules.Entities.CustomerValidator
{
    public class CustomerAddDtoValidator : AbstractValidator<CustomerAddDto>
    {
        public CustomerAddDtoValidator()
        {
            RuleFor(c => c.CustomerId).NotEmpty().WithMessage($"{CustomerMessagesTR.Customer} {BaseConstantsTR.ID} {BaseConstantsTR.NotNull}");
        }
    }
}