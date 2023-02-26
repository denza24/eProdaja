using AutoMapper;
using eProdaja.Models;
using eProdaja.Models.InsertObjects;
using eProdaja.Models.SearchObjects;
using eProdaja.Services.Database;
using eProdaja.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;

namespace eProdaja.Services
{
    public class KorisniciService : BaseCRUDService<Korisnici, KorisniciDto, KorisniciSearchObject, KorisniciInsertObject, KorisniciUpdateObject>, IKorisniciService
    {
        public KorisniciService(EProdajaContext db, IMapper mapper) : base(db, mapper)
        {
        }

        public override KorisniciDto Insert(KorisniciInsertObject insert)
        {
            var korisnik = base.Insert(insert);

            //insert user roles after saving user to the db
            foreach (var ulogaId in insert.UlogeIds)
            {
                var korisnikUloga = new KorisniciUloge
                {
                    KorisnikId = korisnik.KorisnikId,
                    UlogaId = ulogaId,
                    DatumIzmjene = DateTime.Now
                };
                _context.KorisniciUloge.Add(korisnikUloga);
            }

            _context.SaveChanges();

            return korisnik;
        }

        public override void BeforeInsert(KorisniciInsertObject insert, Korisnici entity)
        {
            //create hashed password
            using var hmac = new HMACSHA512();

            entity.LozinkaSalt = Convert.ToBase64String(hmac.Key);
            entity.LozinkaHash = Convert.ToBase64String(hmac.ComputeHash(Encoding.Default.GetBytes(insert.Password)));

            base.BeforeInsert(insert, entity);
        }

        public override IQueryable<Korisnici> AddFilter(IQueryable<Korisnici> query, KorisniciSearchObject? search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            if (!string.IsNullOrWhiteSpace(search?.ImePrezime))
            {
                filteredQuery = filteredQuery.Where(k => (k.Ime + " " + k.Prezime).StartsWith(search.ImePrezime) ||
                                                    (k.Prezime + " " + k.Ime).StartsWith(search.ImePrezime));
            }

            if (!string.IsNullOrWhiteSpace(search?.KorisnickoIme))
            {
                filteredQuery = filteredQuery.Where(k => k.KorisnickoIme.StartsWith(search.KorisnickoIme));
            }

            return filteredQuery;
        }

        public override IQueryable<Korisnici> AddInclude(IQueryable<Korisnici> query, KorisniciSearchObject? search = null)
        {
            var updatedQuery = base.AddInclude(query, search);

            updatedQuery = query.Include(k => k.KorisniciUloges).ThenInclude(ku => ku.Uloga);

            return updatedQuery;
        }

    }
}
