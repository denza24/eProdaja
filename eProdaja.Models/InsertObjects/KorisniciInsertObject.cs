using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eProdaja.Models.InsertObjects
{
    public class KorisniciInsertObject
    {
        [Required]
        public string Ime { get; set; }
        [Required]
        public string Prezime { get; set; }
        [Required]
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Password { get; set; } = string.Empty;
        [Required]
        public string KorisnickoIme { get; set; }
        public List<int> UlogeIds { get; set; } = new List<int>();
    }
}
