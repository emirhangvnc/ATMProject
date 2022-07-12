using BusinessLayer.Abstract.Base;
using EntitiesLayer.Concrete;
using EntitiesLayer.DTOs.CustomerDTO;

namespace BusinessLayer.Abstract
{
    public interface ICustomerService : IBaseService<Customer>,IAddDtoService<CustomerAddDto>,
        IDeleteDtoService<CustomerDeleteDto>,IUpdatedDtoService<CustomerUpdateDto>
    {
    }
}