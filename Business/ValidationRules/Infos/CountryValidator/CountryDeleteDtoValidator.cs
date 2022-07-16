using BusinessLayer.Constants.TR;
using BusinessLayer.Constants.TR.Base;
using BusinessLayer.Constants.TR.General;
using EntitiesLayer.DTOs.CountryDTO;
using FluentValidation;

namespace BusinessLayer.ValidationRules.Infos.CountryValidator
{
    public class CountryDeleteDtoValidator : AbstractValidator<CountryDeleteDto>
    {
        public CountryDeleteDtoValidator()
        {
            RuleFor(c => c.Id).NotEmpty().WithMessage($"{CountryMessagesTR.Country} {BaseConstantsTR.ID} {BaseConstantsTR.NotNull}");
        }
    }
}