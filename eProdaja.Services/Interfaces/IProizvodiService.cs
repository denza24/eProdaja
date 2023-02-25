using eProdaja.Models;
using eProdaja.Models.InsertObjects;
using eProdaja.Models.SearchObjects;
using eProdaja.Models.UpdateObjects;

namespace eProdaja.Services.Interfaces
{
    public interface IProizvodiService : ICRUDService<ProizvodiDto, ProizvodiSearchObject, ProizvodiInsertObject, ProizvodiUpdateObject>
    {

    }
}
