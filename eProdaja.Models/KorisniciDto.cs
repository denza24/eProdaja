using System.Collections.Generic;

namespace eProdaja.Models
{
    public class KorisniciDto
    {
        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string KorisnickoIme { get; set; }
        public bool? Status { get; set; }
        public string Token { get; set; }
        public List<UlogeDto> Uloge { get; set; }
    }
}
