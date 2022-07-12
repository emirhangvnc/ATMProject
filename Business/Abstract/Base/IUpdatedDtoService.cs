using CoreLayer.Entities;
using CoreLayer.Utilities.Results;

namespace BusinessLayer.Abstract.Base
{
    public interface IUpdatedDtoService<T> where T : IDto, new()
    {
        IResult Update(T updatedDto);
    }
}