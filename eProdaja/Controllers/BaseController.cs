using eProdaja.Models.SearchObjects;
using eProdaja.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseController<TDto, TSearch> : ControllerBase where TDto : class where TSearch : BaseSearchObject
    {
        public readonly IService<TDto, TSearch> _service;

        public BaseController(IService<TDto, TSearch> service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<TDto>> Get([FromQuery] TSearch? search = null)
        {
            var list = _service.Get(search);

            return Ok(list);
        }

        [HttpGet("{id}")]
        public ActionResult<TDto> Get(int id)
        {
            return _service.GetById(id);
        }
    }
}
