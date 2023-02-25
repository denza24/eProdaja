using AutoMapper;
using eProdaja.Models;
using eProdaja.Models.InsertObjects;
using eProdaja.Models.SearchObjects;
using eProdaja.Services.Database;
using eProdaja.Services.Interfaces;

namespace eProdaja.Services
{
    public class KorisniciService : BaseCRUDService<Korisnici, KorisniciDto, KorisniciSearchObject, KorisniciInsertObject, KorisniciUpdateObject>, IKorisniciService
    {
        public KorisniciService(EProdajaContext db, IMapper mapper) : base(db, mapper)
        {
        }

        public override IQueryable<Korisnici> AddFilter(IQueryable<Korisnici> query, KorisniciSearchObject? search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            if (!string.IsNullOrWhiteSpace(search?.ImePrezime))
            {
                filteredQuery = filteredQuery.Where(k => (k.Ime + " " + k.Prezime).Equals(search.ImePrezime));
            }

            if (!string.IsNullOrWhiteSpace(search?.KorisnickoIme))
            {
                filteredQuery = filteredQuery.Where(k => k.KorisnickoIme.Equals(search.KorisnickoIme));
            }

            return filteredQuery;
        }
    }
}
