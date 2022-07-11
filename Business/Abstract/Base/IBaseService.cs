using CoreLayer.DataAccess;
using CoreLayer.Utilities.Results;

namespace BusinessLayer.Abstract.Base
{
    public interface IBaseService<T> where T : IEntity,new()
    {
        IDataResult<List<T>> GetAll();
        IDataResult<T> GetById(int id);
    }
}