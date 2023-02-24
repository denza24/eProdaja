using eProdaja.Models;
using eProdaja.Models.SearchObjects;
using eProdaja.Services.Interfaces;

namespace eProdaja.Controllers
{
    public class KorisniciController : BaseController<KorisniciDto, KorisniciSearchObject>
    {
        public KorisniciController(IKorisniciService korisniciService) : base(korisniciService) { }
    }
}
