using BusinessLayer.Constants.TR;
using BusinessLayer.Constants.TR.Base;
using BusinessLayer.Constants.TR.General;
using EntitiesLayer.DTOs.CityDTO;
using FluentValidation;

namespace BusinessLayer.ValidationRules.Infos.CityValidator
{
    public class CityDeleteDtoValidator : AbstractValidator<CityDeleteDto>
    {
        public CityDeleteDtoValidator()
        {
            RuleFor(c => c.Id).NotEmpty().WithMessage($"{CityMessagesTR.City} {BaseConstantsTR.ID} {BaseConstantsTR.NotNull}");
        }
    }
}