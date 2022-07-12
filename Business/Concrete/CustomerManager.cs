using AutoMapper;
using BusinessLayer.Abstract;
using BusinessLayer.Constants.TR;
using BusinessLayer.Constants.TR.Base;
using BusinessLayer.ValidationRules.CustomerValidator;
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
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(), CustomerMessages.CustomersListed);
        }

        public IDataResult<Customer> GetById(int id)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(c => c.Id == id), CustomerMessages.CustomerListed);

        }

        [ValidationAspect(typeof(CustomerAddDtoValidator))]
        public IResult Add(CustomerAddDto addedDto)
        {
            var result = _customerDal.Get(c => c.CustomerId == addedDto.CustomerId);
            if (result != null)
                return new ErrorResult($"Böyle Bir {CustomerMessages.Customer} {BaseConstants.AlreadyAvailable}");

            var customer = _mapper.Map<Customer>(addedDto);
            _customerDal.Add(customer);
            return new SuccessResult(CustomerMessages.CustomerAdded);
        }

        [ValidationAspect(typeof(CustomerDeleteDtoValidator))]
        public IResult Delete(CustomerDeleteDto deletedDto)
        {
            var result = _customerDal.Get(c => c.Id == deletedDto.Id);
            if (result == null)
                return new ErrorResult(CustomerMessages.CustomerNotFound);

            _customerDal.Delete(result);
            return new SuccessResult(CustomerMessages.CustomerDeleted);
        }

        [ValidationAspect(typeof(CustomerUpdateDtoValidator))]
        public IResult Update(CustomerUpdateDto updatedDto)
        {
            var result = _customerDal.Get(c => c.Id == updatedDto.Id);
            if (result == null)
                return new ErrorResult(CustomerMessages.CustomerNotFound);

            var customer = _mapper.Map(updatedDto, result);
            _customerDal.Update(customer);
            return new SuccessResult(CustomerMessages.CustomerUpdated);
        }
    }
}