using AutoMapper;
using BusinessLayer.Abstract;
using BusinessLayer.Constants.TR;
using BusinessLayer.Constants.TR.Base;
using BusinessLayer.ValidationRules.Entities.CustomerValidator;
using CoreLayer.Aspects.Validation;
using CoreLayer.Utilities.Results;
using DataAccessLayer.Abstract;
using EntitiesLayer.Concrete;
using EntitiesLayer.DTOs.CustomerDTO;

namespace BusinessLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        IMapper _mapper;
        public CustomerManager(ICustomerDal customerDal, IMapper mapper)
        {
            _customerDal = customerDal;
            _mapper = mapper;
        }
        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(), CustomerMessagesTR.CustomersListed);
        }

        public IDataResult<Customer> GetById(int id)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(c => c.Id == id), CustomerMessagesTR.CustomerListed);
        }
        [ValidationAspect(typeof(CustomerAddDtoValidator))]
        public IResult Add(CustomerAddDto addedDto)
        {
            var result = _customerDal.Get(c => c.CustomerId == addedDto.CustomerId);
            if (result != null)
                return new ErrorResult($"Böyle Bir {CustomerMessagesTR.Customer} {BaseConstantsTR.AlreadyExists}");

            var customer = _mapper.Map<Customer>(addedDto);
            _customerDal.Add(customer);
            return new SuccessResult(CustomerMessagesTR.CustomerAdded);
        }
        [ValidationAspect(typeof(CustomerDeleteDtoValidator))]
        public IResult Delete(CustomerDeleteDto deletedDto)
        {
            var result = _customerDal.Get(c => c.Id == deletedDto.Id);
            if (result == null)
                return new ErrorResult(CustomerMessagesTR.CustomerNotFound);

            _customerDal.Delete(result);
            return new SuccessResult(CustomerMessagesTR.CustomerDeleted);
        }
        [ValidationAspect(typeof(CustomerUpdateDtoValidator))]
        public IResult Update(CustomerUpdateDto updatedDto)
        {
            var result = _customerDal.Get(c => c.Id == updatedDto.Id);
            if (result == null)
                return new ErrorResult(CustomerMessagesTR.CustomerNotFound);

            var customer = _mapper.Map(updatedDto, result);
            _customerDal.Update(customer);
            return new SuccessResult(CustomerMessagesTR.CustomerUpdated);
        }
    }
}