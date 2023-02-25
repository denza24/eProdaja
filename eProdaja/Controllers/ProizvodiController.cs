using eProdaja.Models;
using eProdaja.Models.InsertObjects;
using eProdaja.Models.SearchObjects;
using eProdaja.Models.UpdateObjects;
using eProdaja.Services.Interfaces;

namespace eProdaja.Controllers
{
    public class ProizvodiController : BaseCRUDController<ProizvodiDto, ProizvodiSearchObject, ProizvodiInsertObject, ProizvodiUpdateObject>
    {
        public ProizvodiController(IProizvodiService proizvodiService) : base(proizvodiService) { }

    }
}
