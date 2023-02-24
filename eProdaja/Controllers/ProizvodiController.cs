using eProdaja.Models;
using eProdaja.Services.Interfaces;

namespace eProdaja.Controllers
{
    public class ProizvodiController : BaseController<ProizvodiDto>
    {
        public ProizvodiController(IProizvodiService proizvodiService) : base(proizvodiService) { }
    }
}
