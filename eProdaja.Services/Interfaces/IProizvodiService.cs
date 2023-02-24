using eProdaja.Services.Database;
using eProdaja.Models;

namespace eProdaja.Services.Interfaces
{
    public interface IProizvodiService
    {
        IEnumerable<ProizvodiDto> Get();
        ProizvodiDto GetById(int id);
    }
}
