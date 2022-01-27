using System.ComponentModel.DataAnnotations;

namespace Panaderia.BL.DTOs
{
    public class MetodoPagoDTO
    {
        public int IdMetodoPago { get; set; }
        [Required]
        public string Detalle { get; set; }
    }
}
