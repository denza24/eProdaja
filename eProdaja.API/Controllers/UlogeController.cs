using eProdaja.Models;
using eProdaja.Models.SearchObjects;
using eProdaja.Models.UpsertObjects;
using eProdaja.Services.Interfaces;

namespace eProdaja.Controllers
{
    public class UlogeController : BaseCRUDController<UlogeDto, BaseSearchObject, UlogeUpsertObject, UlogeUpsertObject>
    {
        public UlogeController(IUlogeService service) : base(service)
        {
        }
    }
}
