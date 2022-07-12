using BusinessLayer.Constants.TR;
using EntitiesLayer.DTOs.CustomerDTO;
using FluentValidation;

namespace BusinessLayer.ValidationRules.CustomerValidator
{
    public class CustomerAddDtoValidator : AbstractValidator<CustomerAddDto>
    {
        public CustomerAddDtoValidator()
        {
            RuleFor(c => c.CustomerId).NotEmpty().WithMessage(CustomerMessages.CustomerIdNotNull);
        }
    }
}