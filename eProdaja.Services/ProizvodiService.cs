﻿using AutoMapper;
using eProdaja.Models;
using eProdaja.Services.Database;
using eProdaja.Services.Interfaces;

namespace eProdaja.Services
{
    public class ProizvodiService : BaseService<Proizvodi, ProizvodiDto>, IProizvodiService
    {
        public ProizvodiService(EProdajaContext db, IMapper mapper) : base(db, mapper)
        {
        }
    }
}
