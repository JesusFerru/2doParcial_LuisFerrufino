using System.ComponentModel.DataAnnotations;

namespace LuisFerrrufino2DOPARCIAL.Models
{
    public class Naipe
    {
       [Key]
        public string NaipeId { get; set; }
        [Required]
        [Display(Name = "Nombre y tipo de la Carta ")]
        public string Nombre { get; set; }
        [Url]
        [Required]
        [Display(Name = "Link de la carta")]
        public string  Imagen { get; set; }
    }
}
