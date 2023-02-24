using eProdaja.Models;
using eProdaja.Services.Interfaces;

namespace eProdaja.Controllers
{
    public class KorisniciController : BaseController<KorisniciDto>
    {
        public KorisniciController(IKorisniciService korisniciService) : base(korisniciService) { }
    }
}
