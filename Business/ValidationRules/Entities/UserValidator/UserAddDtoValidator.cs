using BusinessLayer.Constants.TR;
using BusinessLayer.Constants.TR.Base;
using BusinessLayer.Constants.TR.General;
using EntitiesLayer.DTOs.UserDTO;
using FluentValidation;

namespace BusinessLayer.ValidationRules.Entities.UserValidator
{
    public class UserAddDtoValidator : AbstractValidator<UserAddDto>
    {
        public UserAddDtoValidator()
        {
            RuleFor(u => u.FirstName).NotEmpty().WithMessage($"{UserMessagesTR.UserFirstName} {BaseConstantsTR.NotNull}");
            RuleFor(u => u.FirstName).MaximumLength(50).WithName($"{UserMessagesTR.UserFirstName} {GeneralConstantsTR.Max50Character}");
            RuleFor(u => u.LastName).NotEmpty().WithMessage($"{UserMessagesTR.UserLastName} {BaseConstantsTR.NotNull}");
            RuleFor(u => u.LastName).MaximumLength(50).WithName($"{UserMessagesTR.UserLastName} {GeneralConstantsTR.Max50Character}");
            RuleFor(u => u.DateOfBirth).NotNull().WithMessage($"{BaseConstantsTR.DateOfBirth} {BaseConstantsTR.NotNull}");
            RuleFor(u => u.Email).NotNull().WithMessage($"{BaseConstantsTR.EMail} {BaseConstantsTR.NotNull}");
            RuleFor(u => u.Email).MaximumLength(50).WithName($"{BaseConstantsTR.EMail} {GeneralConstantsTR.Max50Character}");
            RuleFor(u => u.Status).NotNull();
        }
    }
}