using BusinessLayer.Constants.TR;
using EntitiesLayer.DTOs.CustomerDTO;
using FluentValidation;

namespace BusinessLayer.ValidationRules.CustomerValidator
{
    public class CustomerDeleteDtoValidator : AbstractValidator<CustomerDeleteDto>
    {
        public CustomerDeleteDtoValidator()
        {
            RuleFor(c => c.Id).NotEmpty().WithMessage(CustomerMessages.CustomerNotNull);
        }
    }
}