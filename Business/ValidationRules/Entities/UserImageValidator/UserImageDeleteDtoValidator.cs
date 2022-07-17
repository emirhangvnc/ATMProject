using BusinessLayer.Constants.TR;
using BusinessLayer.Constants.TR.Base;
using EntitiesLayer.DTOs.UserImageDTO;
using FluentValidation;

namespace BusinessLayer.ValidationRules.Entities.UserImageValidator
{
    public class UserImageDeleteDtoValidator : AbstractValidator<UserImageDeleteDto>
    {
        public UserImageDeleteDtoValidator()
        {
            RuleFor(u => u.Id).NotEmpty().WithMessage($"{UserImageMessagesTR.UserImage} {BaseConstantsTR.ID} {BaseConstantsTR.NotNull}");
        }
    }
}