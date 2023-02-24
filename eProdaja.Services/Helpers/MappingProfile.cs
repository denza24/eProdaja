using AutoMapper;
using eProdaja.Models;
using eProdaja.Services.Database;

namespace eProdaja.Services.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Proizvodi, ProizvodiDto>();
            CreateMap<Korisnici, KorisniciDto>();
        }
    }
}
