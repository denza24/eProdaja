using eProdaja.Models;
using eProdaja.Models.InsertObjects;
using eProdaja.Models.SearchObjects;

namespace eProdaja.Services.Interfaces
{
    public interface IKorisniciService : ICRUDService<KorisniciDto, KorisniciSearchObject, KorisniciInsertObject, KorisniciUpdateObject>
    {
    }
}
