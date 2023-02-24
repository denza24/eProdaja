﻿using AutoMapper;
using eProdaja.Models;
using eProdaja.Models.SearchObjects;
using eProdaja.Services.Database;
using eProdaja.Services.Interfaces;

namespace eProdaja.Services
{
    public class ProizvodiService : BaseService<Proizvodi, ProizvodiDto, ProizvodiSearchObject>, IProizvodiService
    {
        public ProizvodiService(EProdajaContext db, IMapper mapper) : base(db, mapper)
        {
        }

        public override IQueryable<Proizvodi> AddFilter(IQueryable<Proizvodi> query, ProizvodiSearchObject? search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            if (!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                filteredQuery = filteredQuery.Where(k => k.Naziv.Equals(search.Naziv));
            }

            if (!string.IsNullOrWhiteSpace(search?.Sifra))
            {
                filteredQuery = filteredQuery.Where(k => k.Sifra.Equals(search.Sifra));
            }

            return filteredQuery;
        }
    }
}
