using AutoMapper;
using eProdaja.Services.Database;
using eProdaja.Services.Interfaces;
using eProdaja.Models;

namespace eProdaja.Services
{
    public class ProizvodiService : IProizvodiService
    {
        private readonly EProdajaContext _db;
        private readonly IMapper _mapper;

        public ProizvodiService(EProdajaContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public IEnumerable<ProizvodiDto> Get()
        {
            var proizvodi = _db.Proizvodi.ToList();

            return _mapper.Map<List<ProizvodiDto>>(proizvodi);
        }

        public ProizvodiDto GetById(int id)
        {
            var proizvod = _db.Proizvodi.FirstOrDefault(p => p.ProizvodId == id);

            return _mapper.Map<ProizvodiDto>(proizvod);
        }
    }
}
