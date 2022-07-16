using AutoMapper;
using BusinessLayer.Abstract.Infos;
using BusinessLayer.Constants.TR;
using BusinessLayer.Constants.TR.Base;
using CoreLayer.Utilities.Results;
using DataAccessLayer.Abstract.Infos;
using EntitiesLayer.Concrete.Infos;
using EntitiesLayer.DTOs.CountryDTO;

namespace BusinessLayer.Concrete.Infos
{
    public class CountryManager : ICountryService
    {
        ICountryDal _countryDal; 
        IMapper _mapper;
        public CountryManager(ICountryDal countryDal, IMapper mapper)
        {
            _countryDal = countryDal;
            _mapper = mapper;
        }

        public IDataResult<List<Country>> GetAll()
        {
            return new SuccessDataResult<List<Country>>(_countryDal.GetAll(),CountryMessagesTR.CountriesListed);
        }

        public IDataResult<Country> GetById(int id)
        {
            return new SuccessDataResult<Country>(_countryDal.Get(c => c.Id == id),CountryMessagesTR.CountryListed);
        }

        public IResult Add(CountryAddDto addedDto)
        {
            var result = _countryDal.Get(c => c.CountryCode == addedDto.CountryCode);
            if (result != null)
                return new ErrorResult($"Böyle Bir {CountryMessagesTR.Country} {BaseConstantsTR.AlreadyAvailable}");

            var country = _mapper.Map<Country>(addedDto);
            _countryDal.Add(country);
            return new SuccessResult(CountryMessagesTR.CountryAdded);
        }

        public IResult Delete(CountryDeleteDto deletedDto)
        {
            var result = _countryDal.Get(c => c.Id == deletedDto.Id);
            if (result == null)
                return new ErrorResult(CountryMessagesTR.CountryNotFound);

            _countryDal.Delete(result);
            return new SuccessResult(CountryMessagesTR.CountryDeleted);
        }

        public IResult Update(CountryUpdateDto updatedDto)
        {
            var result = _countryDal.Get(c => c.Id == updatedDto.Id);
            if (result == null)
                return new ErrorResult(CountryMessagesTR.CountryNotFound);

            var country = _mapper.Map(updatedDto, result);
            _countryDal.Update(country);
            return new SuccessResult(CountryMessagesTR.CountryUpdated);
        }
    }
}