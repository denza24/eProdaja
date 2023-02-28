using eProdaja.Models;
using eProdaja.Models.InsertObjects;
using eProdaja.Models.SearchObjects;
using eProdaja.Models.UpdateObjects;
using eProdaja.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.Controllers
{
    public class ProizvodiController : BaseCRUDController<ProizvodiDto, ProizvodiSearchObject, ProizvodiInsertObject, ProizvodiUpdateObject>
    {
        public IProizvodiService ProizvodiService { get; }

        public ProizvodiController(IProizvodiService proizvodiService) : base(proizvodiService)
        {
            ProizvodiService = proizvodiService;
        }

        [HttpPut("{id}/activate")]
        public ActionResult<ProizvodiDto> Activate(int id)
        {
            return ProizvodiService.Activate(id);
        }

        [HttpPut("{id}/hide")]
        public ActionResult<ProizvodiDto> Hide(int id)
        {
            return ProizvodiService.Hide(id);
        }

    }
}
