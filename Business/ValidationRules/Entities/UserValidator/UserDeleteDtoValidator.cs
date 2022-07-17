using BusinessLayer.Constants.TR;
using BusinessLayer.Constants.TR.Base;
using BusinessLayer.Constants.TR.General;
using EntitiesLayer.DTOs.UserDTO;
using FluentValidation;

namespace BusinessLayer.ValidationRules.Entities.UserValidator
{
    public class UserDeleteDtoValidator : AbstractValidator<UserDeleteDto>
    {
        public UserDeleteDtoValidator()
        {
            RuleFor(u => u.Id).NotNull().WithMessage($"{UserMessagesTR.User} {BaseConstantsTR.ID} {BaseConstantsTR.NotNull}");
        }
    }
}