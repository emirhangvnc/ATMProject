using BusinessLayer.Abstract.Base;
using EntitiesLayer.Concrete.Infos;
using EntitiesLayer.DTOs.CityDTO;

namespace BusinessLayer.Abstract.Infos
{
    public interface ICityService: IBaseService<City>,IAddDtoService<CityAddDto>,
        IDeleteDtoService<CityDeleteDto>,IUpdatedDtoService<CityUpdateDto>
    {
    }
}