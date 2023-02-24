using eProdaja.Models;
using eProdaja.Models.SearchObjects;
using eProdaja.Services.Interfaces;

namespace eProdaja.Controllers
{
    public class JediniceMjereController : BaseController<JediniceMjereDto, BaseSearchObject>
    {
        public JediniceMjereController(IJediniceMjereService jediniceMjereService) : base(jediniceMjereService) { }
    }
}
