using AutoMapper;
using eProdaja.Services.Database;
using eProdaja.Services.Interfaces;

namespace eProdaja.Services
{
    public class BaseService<T, TDto> : IService<TDto> where TDto : class where T : class
    {
        private readonly EProdajaContext _context;
        private readonly IMapper _mapper;

        public BaseService(EProdajaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IEnumerable<TDto> Get()
        {
            var entities = _context.Set<T>().ToList();

            return _mapper.Map<List<TDto>>(entities);
        }

        public TDto GetById(int id)
        {
            var entity = _context.Set<T>().Find(id);

            return _mapper.Map<TDto>(entity);
        }
    }
}
