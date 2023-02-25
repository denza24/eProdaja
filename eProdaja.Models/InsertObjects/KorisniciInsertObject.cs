using System.ComponentModel.DataAnnotations;

namespace eProdaja.Models.InsertObjects
{
    public class KorisniciInsertObject
    {
        [Required]
        public string Ime { get; set; }
        [Required]
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string LozinkaHash { get; set; } = string.Empty;
        public string LozinkaSalt { get; set; } = string.Empty;
        [Required]
        public string KorisnickoIme { get; set; }
    }
}
