using eProdaja.Models.SearchObjects;
using eProdaja.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.Controllers
{
    public class BaseCRUDController<TDto, TSearch, TInsert, TUpdate> :
        BaseController<TDto, TSearch> where TDto : class where TSearch : BaseSearchObject where TInsert : class where TUpdate : class
    {

        public BaseCRUDController(ICRUDService<TDto, TSearch, TInsert, TUpdate> service) : base(service)
        {
        }

        [HttpPost]
        public ActionResult<TDto> Insert(TInsert insert)
        {
            var result = ((ICRUDService<TDto, TSearch, TInsert, TUpdate>)_service).Insert(insert);

            return result;
        }

        [HttpPut("{id}")]
        public ActionResult<TDto> Insert(int id, TUpdate update)
        {
            var result = ((ICRUDService<TDto, TSearch, TInsert, TUpdate>)_service).Update(id, update);

            return result;
        }
    }
}
