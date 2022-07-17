using BusinessLayer.Constants.TR;
using BusinessLayer.Constants.TR.Base;
using EntitiesLayer.DTOs.UserImageDTO;
using FluentValidation;

namespace BusinessLayer.ValidationRules.Entities.UserImageValidator
{
    public class UserImageUpdateDtoValidator : AbstractValidator<UserImageUpdateDto>
    {
        public UserImageUpdateDtoValidator()
        {
            RuleFor(u => u.Id).NotEmpty().WithMessage($"{UserImageMessagesTR.UserImage} {BaseConstantsTR.ID} {BaseConstantsTR.NotNull}");
            RuleFor(u => u.UserId).NotEmpty().WithMessage($"{UserMessagesTR.User} {BaseConstantsTR.ID} {BaseConstantsTR.NotNull}");
        }
    }
}