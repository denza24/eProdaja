using eProdaja.Models;
using eProdaja.Models.SearchObjects;
using eProdaja.Services.Interfaces;

namespace eProdaja.Controllers
{
    public class ProizvodiController : BaseController<ProizvodiDto, ProizvodiSearchObject>
    {
        public ProizvodiController(IProizvodiService proizvodiService) : base(proizvodiService) { }
    }
}
