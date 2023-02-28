using AutoMapper;
using eProdaja.Models.UpdateObjects;
using eProdaja.Services.Database;

namespace eProdaja.Services.StateMachine
{
    public class ProductHiddenState : ProductBaseState
    {
        public ProductHiddenState(IServiceProvider serviceProvider, EProdajaContext context, IMapper mapper) : base(serviceProvider, context, mapper)
        {
        }

        public override void Update(ProizvodiUpdateObject update)
        {
            Mapper.Map(update, CurrentEntity);
            CurrentEntity.StateMachine = "hidden";

            Context.SaveChanges();
        }

        public override void Activate()
        {
            CurrentEntity.StateMachine = "active";
            Context.SaveChanges();
        }

        public override void Delete()
        {
            CurrentEntity.StateMachine = "delete";
            CurrentEntity.Obrisan = true;

            Context.SaveChanges();
        }
    }
}
