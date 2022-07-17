using BusinessLayer.Constants.TR;
using BusinessLayer.Constants.TR.Base;
using EntitiesLayer.DTOs.UserImageDTO;
using FluentValidation;

namespace BusinessLayer.ValidationRules.Entities.UserImageValidator
{
    public class UserImageAddDtoValidator : AbstractValidator<UserImageAddDto>
    {
        public UserImageAddDtoValidator()
        {
            RuleFor(u => u.UserId).NotEmpty().WithMessage($"{UserMessagesTR.User} {BaseConstantsTR.ID} {BaseConstantsTR.NotNull}");
        }
    }
}