using eProdaja.Models;
using eProdaja.Models.InsertObjects;
using eProdaja.Models.SearchObjects;
using eProdaja.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;

namespace eProdaja.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class KorisniciController : BaseCRUDController<KorisniciDto, KorisniciSearchObject, KorisniciInsertObject, KorisniciUpdateObject>
    {
        public KorisniciController(IKorisniciService korisniciService) : base(korisniciService) { }
    }
}
