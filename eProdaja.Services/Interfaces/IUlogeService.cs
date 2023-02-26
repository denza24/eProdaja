using eProdaja.Models;
using eProdaja.Models.SearchObjects;
using eProdaja.Models.UpsertObjects;

namespace eProdaja.Services.Interfaces
{
    public interface IUlogeService : ICRUDService<UlogeDto, BaseSearchObject, UlogeUpsertObject, UlogeUpsertObject>
    {
    }
}
