using eProdaja.Models;

namespace eProdaja.Services.Interfaces
{
    public interface IKorisniciService
    {
        IEnumerable<KorisniciDto> Get();
        ProizvodiDto GetById(int id);
    }
}
