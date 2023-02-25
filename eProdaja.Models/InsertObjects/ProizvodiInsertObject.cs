using System.ComponentModel.DataAnnotations;

namespace eProdaja.Models.InsertObjects
{
    public class ProizvodiInsertObject
    {
        [Required]
        public string Naziv { get; set; }
        [Required]
        public string Sifra { get; set; }
        [Required]
        public decimal? Cijena { get; set; }
        [Required]
        public int? VrstaId { get; set; }
        [Required]
        public int? JedinicaMjereId { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
    }
}
