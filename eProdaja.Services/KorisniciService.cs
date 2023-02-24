using AutoMapper;
using eProdaja.Models;
using eProdaja.Services.Database;
using eProdaja.Services.Interfaces;

namespace eProdaja.Services
{
    public class KorisniciService : BaseService<Korisnici, KorisniciDto>, IKorisniciService
    {
        public KorisniciService(EProdajaContext db, IMapper mapper) : base(db, mapper)
        {
        }
    }
}
