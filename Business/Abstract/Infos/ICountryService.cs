using BusinessLayer.Abstract.Base;
using EntitiesLayer.Concrete.Infos;
using EntitiesLayer.DTOs.CountryDTO;

namespace BusinessLayer.Abstract.Infos
{
    public interface ICountryService : IBaseService<Country>, IAddDtoService<CountryAddDto>,
        IDeleteDtoService<CountryDeleteDto>, IUpdatedDtoService<CountryUpdateDto>
    {
    }
}