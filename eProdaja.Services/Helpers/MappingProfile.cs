using AutoMapper;
using eProdaja.Models;
using eProdaja.Models.InsertObjects;
using eProdaja.Models.UpdateObjects;
using eProdaja.Services.Database;

namespace eProdaja.Services.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Proizvodi, ProizvodiDto>();
            CreateMap<ProizvodiInsertObject, Proizvodi>();
            CreateMap<ProizvodiUpdateObject, Proizvodi>();

            CreateMap<Korisnici, KorisniciDto>();
            CreateMap<KorisniciInsertObject, Korisnici>();
            CreateMap<KorisniciUpdateObject, Korisnici>();
        }
    }
}
