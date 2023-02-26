using eProdaja.Models.SearchObjects;

namespace eProdaja.Services.Interfaces
{
    public interface ICRUDService<TDto, TSearch, TInsert, TUpdate> : IService<TDto, TSearch>
        where TDto : class where TSearch : BaseSearchObject where TInsert : class where TUpdate : class
    {
        TDto Insert(TInsert insert);
        TDto Update(int id, TUpdate update);
        bool Delete(int id);
    }
}
