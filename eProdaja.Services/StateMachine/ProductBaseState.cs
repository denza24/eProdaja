using AutoMapper;
using eProdaja.Models;
using eProdaja.Models.InsertObjects;
using eProdaja.Models.UpdateObjects;
using eProdaja.Services.Database;
using Microsoft.Extensions.DependencyInjection;

namespace eProdaja.Services.StateMachine
{
    public class ProductBaseState
    {
        public IMapper Mapper { get; }
        public IServiceProvider ServiceProvider { get; }
        public EProdajaContext Context { get; }
        public Proizvodi CurrentEntity { get; set; } = null!;

        public ProductBaseState(IServiceProvider serviceProvider, EProdajaContext context, IMapper mapper)
        {
            ServiceProvider = serviceProvider;
            Context = context;
            Mapper = mapper;
        }

        public virtual ProizvodiDto Insert(ProizvodiInsertObject insert)
        {
            throw new Exception("Not allowed!");
        }

        public virtual void Update(ProizvodiUpdateObject update)
        {
            throw new Exception("Not allowed!");
        }

        public virtual void Activate()
        {
            throw new Exception("Not allowed!");
        }

        public virtual void Hide()
        {
            throw new Exception("Not allowed!");
        }

        public virtual void Delete()
        {
            throw new Exception("Not allowed!");
        }

        public ProductBaseState CreateState(string stateName)
        {
            switch (stateName)
            {
                case "initial":
                    return ServiceProvider.GetService<ProductInitialState>()!;
                case "draft":
                    return ServiceProvider.GetService<ProductDraftState>()!;
                case "active":
                    return ServiceProvider.GetService<ProductActiveState>()!;
                default:
                    throw new Exception("Not supported");
            }
        }

    }
}
