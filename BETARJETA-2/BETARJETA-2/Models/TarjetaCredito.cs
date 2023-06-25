using System.ComponentModel.DataAnnotations;

namespace BETARJETA_2.Models
{
    public class TarjetaCredito
    {
        public int id { get; set; }
        [Required]
        public String Titular { get; set; }
        [Required]
        public String NumeroTarjeta { get; set; }
        [Required]
        public string FechaExpiracion { get; set;}
        [Required]
        public String CVV { get; set; }
    }
}
