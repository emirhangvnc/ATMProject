using CoreLayer.Entities;
using CoreLayer.Utilities.Results;

namespace BusinessLayer.Abstract.Base
{
    public interface IAddDtoService<T> where T : IDto, new()
    {
        IResult Add(T addedDto);
    }
}