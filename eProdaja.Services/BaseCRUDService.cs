﻿using AutoMapper;
using eProdaja.Models.SearchObjects;
using eProdaja.Services.Database;
using eProdaja.Services.Interfaces;

namespace eProdaja.Services
{
    public class BaseCRUDService<T, TDto, TSearch, TInsert, TUpdate> :
        BaseService<T, TDto, TSearch>,
        ICRUDService<TDto, TSearch, TInsert, TUpdate>
        where T : class where TDto : class where TSearch : BaseSearchObject where TInsert : class where TUpdate : class

    {
        public BaseCRUDService(EProdajaContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public TDto Insert(TInsert insert)
        {
            var entity = _mapper.Map<T>(insert);
            _context.Set<T>().Add(entity);

            _context.SaveChanges();

            return _mapper.Map<TDto>(entity);
        }

        public TDto Update(int id, TUpdate update)
        {
            var entity = _context.Set<T>().Find(id);

            _mapper.Map(update, entity);
            _context.SaveChanges();

            return _mapper.Map<TDto>(entity);
        }

    }
}
