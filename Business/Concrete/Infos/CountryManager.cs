using BusinessLayer.Abstract.Infos;
using CoreLayer.Utilities.Results;
using EntitiesLayer.Concrete.Infos;

namespace BusinessLayer.Concrete.Infos
{
    public class CountryManager : ICountryService
    {
        public IDataResult<List<Country>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Country> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}