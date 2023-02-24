namespace eProdaja.Services.Interfaces
{
    public interface IService<T>
    {
        IEnumerable<T> Get();
        T GetById(int id);
    }
}
