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
            return new SuccessDataResult<List<Country>>(_countryDal.GetAll(),CountryMessages.CountriesListed);
        }

        public IDataResult<Country> GetById(int id)
        {
            return new SuccessDataResult<Country>(_countryDal.Get(c => c.Id == id),CountryMessages.CountryListed);
        }

        public IResult Add(CountryAddDto addedDto)
        {
            var result = _countryDal.Get(c => c.CountryCode == addedDto.CountryCode);
            if (result != null)
                return new ErrorResult($"Böyle Bir {CountryMessages.Country} {BaseConstants.AlreadyAvailable}");

            var country = _mapper.Map<Country>(addedDto);
            _countryDal.Add(country);
            return new SuccessResult(CountryMessages.CountryAdded);
        }

        public IResult Delete(CountryDeleteDto deletedDto)
        {
            var result = _countryDal.Get(c => c.Id == deletedDto.Id);
            if (result == null)
                return new ErrorResult(CountryMessages.CountryNotFound);

            _countryDal.Delete(result);
            return new SuccessResult(CountryMessages.CountryDeleted);
        }

        public IResult Update(CountryUpdateDto updatedDto)
        {
            var result = _countryDal.Get(c => c.Id == updatedDto.Id);
            if (result == null)
                return new ErrorResult(CountryMessages.CountryNotFound);

            var country = _mapper.Map(updatedDto, result);
            _countryDal.Update(country);
            return new SuccessResult(CountryMessages.CountryUpdated);
        }
    }
}