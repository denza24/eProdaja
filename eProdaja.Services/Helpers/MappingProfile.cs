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

            CreateMap<Korisnici, KorisniciDto>().ForMember(k => k.Uloge, opt => opt.MapFrom(k => k.KorisniciUloges.Select(ku => ku.Uloga)));
            CreateMap<KorisniciInsertObject, Korisnici>();
            CreateMap<KorisniciUpdateObject, Korisnici>();

            CreateMap<Uloge, UlogeDto>().ForMember(u => u.Id, opt => opt.MapFrom(u => u.UlogaId));

        }
    }
}
