using BusinessLayer.Abstract.Infos;
using CoreLayer.Utilities.Results;
using EntitiesLayer.Concrete.Infos;

namespace BusinessLayer.Concrete.Infos
{
    public class CityManager : ICityService
    {
        public IDataResult<List<City>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<City> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}