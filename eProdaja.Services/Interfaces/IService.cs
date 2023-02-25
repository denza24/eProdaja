using eProdaja.Models.SearchObjects;

namespace eProdaja.Services.Interfaces
{
    public interface IService<TDto, TSearch> where TDto : class where TSearch : BaseSearchObject
    {
        IEnumerable<TDto> Get(TSearch? name = null);
        TDto GetById(int id);
    }
}
