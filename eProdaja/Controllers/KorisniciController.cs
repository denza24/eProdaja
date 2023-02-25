using eProdaja.Models;
using eProdaja.Models.InsertObjects;
using eProdaja.Models.SearchObjects;
using eProdaja.Services.Interfaces;

namespace eProdaja.Controllers
{
    public class KorisniciController : BaseCRUDController<KorisniciDto, KorisniciSearchObject, KorisniciInsertObject, KorisniciUpdateObject>
    {
        public KorisniciController(IKorisniciService korisniciService) : base(korisniciService) { }
    }
}
