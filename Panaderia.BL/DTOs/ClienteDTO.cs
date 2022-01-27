using System.ComponentModel.DataAnnotations;

namespace Panaderia.BL.DTOs
{
    public class ClienteDTO
    {
        
        public int IdCliente { get; set; }
        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        public string Telefono { get; set; }
        [Required]
        public int IdDireccion { get; set; }
        //public DireccionDTO Direccion { get; set; }

        /*
        public string FullName
        {
            get { return string.Format("{0} {1}", Nombre, Apellido);}
        }*/

    }
}
