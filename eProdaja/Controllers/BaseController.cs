using eProdaja.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseController<T> : ControllerBase
    {
        private readonly IService<T> _service;

        public BaseController(IService<T> service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<T>> Get()
        {
            var list = _service.Get();

            return Ok(list);
        }

        [HttpGet("{id}")]
        public ActionResult<T> Get(int id)
        {
            return _service.GetById(id);
        }
    }
}
