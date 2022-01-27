using System.ComponentModel.DataAnnotations;

namespace Panaderia.BL.DTOs
{
    public class DireccionDTO
    {
        public int IdDireccion { get; set; }
        [Required]
        public string Detalle { get; set; }
    }
}
