using AutoMapper;
using eProdaja.Models.SearchObjects;
using eProdaja.Services.Database;
using eProdaja.Services.Interfaces;

namespace eProdaja.Services
{
    public class BaseService<T, TDto, TSearch> : IService<TDto, TSearch> where TDto : class where T : class where TSearch : BaseSearchObject
    {
        private readonly EProdajaContext _context;
        private readonly IMapper _mapper;

        public BaseService(EProdajaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IEnumerable<TDto> Get(TSearch? search = null)
        {
            var entities = _context.Set<T>().AsQueryable();

            entities = AddFilter(entities, search);

            if (search?.Page.HasValue == true && search?.PageSize.HasValue == true)
            {
                entities = entities.Skip((search.Page.Value - 1) * search.PageSize.Value).Take(search.PageSize.Value);
            }

            return _mapper.Map<List<TDto>>(entities.ToList());
        }

        public TDto GetById(int id)
        {
            var entity = _context.Set<T>().Find(id);

            return _mapper.Map<TDto>(entity);
        }

        public virtual IQueryable<T> AddFilter(IQueryable<T> query, TSearch? search = null)
        {
            return query;
        }

    }
}
