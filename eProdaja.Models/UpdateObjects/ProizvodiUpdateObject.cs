using System.ComponentModel.DataAnnotations;

namespace eProdaja.Models.UpdateObjects
{
    public class ProizvodiUpdateObject
    {
        [Required]
        public string Naziv { get; set; }
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
