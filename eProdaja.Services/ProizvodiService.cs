using AutoMapper;
using eProdaja.Models;
using eProdaja.Models.InsertObjects;
using eProdaja.Models.SearchObjects;
using eProdaja.Models.UpdateObjects;
using eProdaja.Services.Database;
using eProdaja.Services.Interfaces;
using eProdaja.Services.StateMachine;

namespace eProdaja.Services
{
    public class ProizvodiService : BaseCRUDService<Proizvodi, ProizvodiDto, ProizvodiSearchObject, ProizvodiInsertObject, ProizvodiUpdateObject>, IProizvodiService
    {
        public ProductBaseState BaseState { get; }
        public ProizvodiService(EProdajaContext db, IMapper mapper, ProductBaseState baseState) : base(db, mapper)
        {
            BaseState = baseState;
        }

        public override IQueryable<Proizvodi> AddFilter(IQueryable<Proizvodi> query, ProizvodiSearchObject? search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            if (!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                filteredQuery = filteredQuery.Where(k => k.Naziv.Equals(search.Naziv));
            }

            if (!string.IsNullOrWhiteSpace(search?.Sifra))
            {
                filteredQuery = filteredQuery.Where(k => k.Sifra.Equals(search.Sifra));
            }

            return filteredQuery;
        }

        public override ProizvodiDto Insert(ProizvodiInsertObject insert)
        {
            var state = BaseState.CreateState("initial");

            return state.Insert(insert);
        }

        public override ProizvodiDto Update(int id, ProizvodiUpdateObject update)
        {
            var product = _context.Proizvodi.Find(id);
            if (product == null) return null;

            var state = BaseState.CreateState(product.StateMachine);

            state.CurrentEntity = product;
            state.Update(update);

            return GetById(id);
        }

        public ProizvodiDto Activate(int id)
        {
            var product = _context.Proizvodi.Find(id);
            if (product == null) return null;

            var state = BaseState.CreateState(product.StateMachine);
            state.CurrentEntity = product;

            state.Activate();

            return GetById(id);
        }

        public ProizvodiDto Hide(int id)
        {
            var product = _context.Proizvodi.Find(id);
            if (product == null) return null;

            var state = BaseState.CreateState(product.StateMachine);
            state.CurrentEntity = product;

            state.Hide();

            return GetById(id);
        }

        public override bool Delete(int id)
        {
            var product = _context.Proizvodi.Find(id);
            if (product == null) return false;

            var state = BaseState.CreateState(product.StateMachine);
            state.CurrentEntity = product;

            state.Delete();

            return true;
        }

        public List<string> AllowedActions(int id)
        {
            throw new NotImplementedException();
        }
    }
}
