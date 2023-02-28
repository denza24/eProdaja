using eProdaja.Models;
using eProdaja.Models.InsertObjects;
using eProdaja.Models.SearchObjects;
using eProdaja.Models.UpdateObjects;

namespace eProdaja.Services.Interfaces
{
    public interface IProizvodiService : ICRUDService<ProizvodiDto, ProizvodiSearchObject, ProizvodiInsertObject, ProizvodiUpdateObject>
    {
        ProizvodiDto Activate(int id);
        ProizvodiDto Hide(int id);
        List<string> AllowedActions(int id);
    }
}
