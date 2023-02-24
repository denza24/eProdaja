using eProdaja.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseController<T, TSearch> : ControllerBase where T : class where TSearch : class
    {
        private readonly IService<T, TSearch> _service;

        public BaseController(IService<T, TSearch> service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<T>> Get([FromQuery] TSearch? search = null)
        {
            var list = _service.Get(search);

            return Ok(list);
        }

        [HttpGet("{id}")]
        public ActionResult<T> Get(int id)
        {
            return _service.GetById(id);
        }
    }
}
