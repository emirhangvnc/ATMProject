using CoreLayer.Entities;
using CoreLayer.Utilities.Results;

namespace BusinessLayer.Abstract.Base
{
    public interface IDeleteDtoService<T> where T : IDto, new()
    {
        IResult Delete(T deletedDto);
    }
}
