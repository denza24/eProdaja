namespace eProdaja.Services.Interfaces
{
    public interface IService<T, TSearch> where TSearch : class
    {
        IEnumerable<T> Get(TSearch? name = null);
        T GetById(int id);
    }
}
