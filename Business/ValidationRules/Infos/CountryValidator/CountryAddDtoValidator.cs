using BusinessLayer.Constants.TR;
using BusinessLayer.Constants.TR.Base;
using BusinessLayer.Constants.TR.General;
using EntitiesLayer.DTOs.CountryDTO;
using FluentValidation;

namespace BusinessLayer.ValidationRules.Infos.CountryValidator
{
    public class CountryAddDtoValidator : AbstractValidator<CountryAddDto>
    {
        public CountryAddDtoValidator()
        {
            RuleFor(c => c.CountryName).NotEmpty().WithMessage($"{CountryMessagesTR.Country} {BaseConstantsTR.Name} {BaseConstantsTR.NotNull}");
            RuleFor(c => c.CountryName).MaximumLength(50).WithMessage($"{CountryMessagesTR.Country} {BaseConstantsTR.Name} {GeneralConstantsTR.Max50Character}");
            RuleFor(c => c.CountryCode).NotEmpty().WithMessage($"{CountryMessagesTR.Country} {BaseConstantsTR.Code}u {BaseConstantsTR.NotNull}");
            RuleFor(c => c.CountryCode).MaximumLength(30).WithMessage($"{CountryMessagesTR.Country} {BaseConstantsTR.Code}u {GeneralConstantsTR.Max30Character}");
        }
    }
}