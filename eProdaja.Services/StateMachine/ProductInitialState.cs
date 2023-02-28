using AutoMapper;
using eProdaja.Models;
using eProdaja.Models.InsertObjects;
using eProdaja.Services.Database;

namespace eProdaja.Services.StateMachine
{
    public class ProductInitialState : ProductBaseState
    {
        public ProductInitialState(IServiceProvider serviceProvider, EProdajaContext context, IMapper mapper) : base(serviceProvider, context, mapper)
        {
        }

        public override ProizvodiDto Insert(ProizvodiInsertObject insert)
        {
            var entity = Mapper.Map<Proizvodi>(insert);
            Context.Set<Proizvodi>().Add(entity);

            entity.StateMachine = "draft";

            Context.SaveChanges();

            return Mapper.Map<ProizvodiDto>(entity);
        }
    }
}
