using AutoMapper;
using eProdaja.Services.Database;

namespace eProdaja.Services.StateMachine
{
    public class ProductActiveState : ProductBaseState
    {
        public ProductActiveState(IServiceProvider serviceProvider, EProdajaContext context, IMapper mapper) : base(serviceProvider, context, mapper)
        {
        }

        public override void Hide()
        {
            CurrentEntity.StateMachine = "hidden";
            Context.SaveChanges();
        }
    }
}
