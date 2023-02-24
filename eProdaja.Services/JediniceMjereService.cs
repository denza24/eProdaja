using AutoMapper;
using eProdaja.Models;
using eProdaja.Models.SearchObjects;
using eProdaja.Services.Database;
using eProdaja.Services.Interfaces;

namespace eProdaja.Services
{
    public class JediniceMjereService : BaseService<JediniceMjere, JediniceMjereDto, BaseSearchObject>, IJediniceMjereService
    {
        public JediniceMjereService(EProdajaContext db, IMapper mapper) : base(db, mapper)
        {
        }

    }
}
