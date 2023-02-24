using AutoMapper;
using eProdaja.Services.Database;
using eProdaja.Models;

namespace eProdaja.Services.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Proizvodi, ProizvodiDto>();
        }
    }
}
