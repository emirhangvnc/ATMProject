using BusinessLayer.Constants.TR;
using BusinessLayer.Constants.TR.Base;
using BusinessLayer.Constants.TR.General;
using EntitiesLayer.DTOs.CityDTO;
using FluentValidation;

namespace BusinessLayer.ValidationRules.Infos.CityValidator
{
    public class CityAddDtoValidator : AbstractValidator<CityAddDto>
    {
        public CityAddDtoValidator()
        {
            RuleFor(c => c.CityName).NotEmpty().WithMessage($"{CityMessagesTR.City} {BaseConstantsTR.Name} {BaseConstantsTR.NotNull}");
            RuleFor(c => c.CityName).MaximumLength(50).WithMessage($"{CityMessagesTR.City} {BaseConstantsTR.Name} {GeneralConstantsTR.Max50Character}");
            RuleFor(c => c.CityCode).NotEmpty().WithMessage($"{CityMessagesTR.City} {BaseConstantsTR.Code}u {BaseConstantsTR.NotNull}");
            RuleFor(c => c.CityCode).MaximumLength(30).WithMessage($"{CityMessagesTR.City} {BaseConstantsTR.Code}u {GeneralConstantsTR.Max30Character}");
        }
    }
}