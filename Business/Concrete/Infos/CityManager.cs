using AutoMapper;
using BusinessLayer.Abstract.Infos;
using BusinessLayer.Constants.TR;
using BusinessLayer.Constants.TR.Base;
using CoreLayer.Utilities.Results;
using DataAccessLayer.Abstract.Infos;
using EntitiesLayer.Concrete.Infos;
using EntitiesLayer.DTOs.CityDTO;

namespace BusinessLayer.Concrete.Infos
{
    public class CityManager : ICityService
    {
        ICityDal _cityDal;
        IMapper _mapper;
        public CityManager(ICityDal cityDal, IMapper mapper)
        {
            _cityDal= cityDal;
            _mapper = mapper;
        }

        public IDataResult<List<City>> GetAll()
        {
            return new SuccessDataResult<List<City>>(_cityDal.GetAll(), CityMessagesTR.CitiesListed);
        }

        public IDataResult<City> GetById(int id)
        {
            return new SuccessDataResult<City>(_cityDal.Get(c=>c.Id==id), CityMessagesTR.CityListed);
        }

        public IResult Add(CityAddDto addedDto)
        {
            var result = _cityDal.Get(c => c.CityCode == addedDto.CityCode);
            if (result != null)
                return new ErrorResult($"Böyle Bir {CityMessagesTR.City} {BaseConstantsTR.AlreadyAvailable}");

            var city = _mapper.Map<City>(addedDto);
            _cityDal.Add(city);
            return new SuccessResult(CityMessagesTR.CityAdded);
        }

        public IResult Delete(CityDeleteDto deletedDto)
        {
            var result = _cityDal.Get(c => c.Id == deletedDto.Id);
            if (result == null)
                return new ErrorResult(CityMessagesTR.CityNotFound);

            _cityDal.Delete(result);
            return new SuccessResult(CityMessagesTR.CityDeleted);
        }

        public IResult Update(CityUpdateDto updatedDto)
        {
            var result = _cityDal.Get(c => c.Id == updatedDto.Id);
            if (result == null)
                return new ErrorResult(CityMessagesTR.CityNotFound);

            var city = _mapper.Map(updatedDto, result);
            _cityDal.Update(city);
            return new SuccessResult(CityMessagesTR.CityUpdated);
        }
    }
}