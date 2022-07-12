using BusinessLayer.Constants.TR;
using EntitiesLayer.DTOs.CustomerDTO;
using FluentValidation;

namespace BusinessLayer.ValidationRules.CustomerValidator
{
    public class CustomerUpdateDtoValidator : AbstractValidator<CustomerUpdateDto>
    {
        public CustomerUpdateDtoValidator()
        {
            RuleFor(c => c.Id).NotEmpty().WithMessage(CustomerMessages.CustomerNotNull);
            RuleFor(c => c.CustomerId).NotEmpty().WithMessage(CustomerMessages.CustomerIdNotNull);
        }
    }
}