using AutoMapper;
using eProdaja.Models;
using eProdaja.Models.SearchObjects;
using eProdaja.Models.UpsertObjects;
using eProdaja.Services.Database;
using eProdaja.Services.Interfaces;

namespace eProdaja.Services
{
    public class UlogeService : BaseCRUDService<Uloge, UlogeDto, BaseSearchObject, UlogeUpsertObject, UlogeUpsertObject>,
            IUlogeService
    {
        public UlogeService(EProdajaContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
