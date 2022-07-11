using BusinessLayer.Abstract.Base;
using CoreLayer.Utilities.Results;
using EntitiesLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface ICustomerService : IBaseService<Customer>
    {
    }
}