using eProdaja.Services.Database;
using eProdaja.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using eProdaja.Models;

namespace eProdaja.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProizvodiController : ControllerBase
    {
        private readonly IProizvodiService _proizvodiService;

        public ProizvodiController(IProizvodiService proizvodiService)
        {
            _proizvodiService = proizvodiService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ProizvodiDto>> Get()
        {
            var proizvodi = _proizvodiService.Get();

            return Ok(proizvodi);
        }

        [HttpGet("{id}")]
        public ActionResult<ProizvodiDto> Get(int id)
        {
            return _proizvodiService.GetById(id);
        }
    }
}
