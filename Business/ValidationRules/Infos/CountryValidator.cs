using EntitiesLayer.Concrete.Infos;
using FluentValidation;

namespace BusinessLayer.ValidationRules.Infos
{
    public class CountryValidator:AbstractValidator<Country>
    {
        public CountryValidator()
        {
            RuleFor(c => c.CountryName).NotEmpty().WithMessage("Ülke İsmi Boş Geçilemez");
            RuleFor(c => c.CountryCode).NotEmpty().WithMessage("Ülke Kodu Boş Geçilemez");
        }
    }
}