using System.ComponentModel.DataAnnotations;

namespace eProdaja.Models.InsertObjects
{
    public class KorisniciUpdateObject
    {
        [Required]
        public string Ime { get; set; }
        [Required]
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        [Required]
        public string KorisnickoIme { get; set; }
    }
}
