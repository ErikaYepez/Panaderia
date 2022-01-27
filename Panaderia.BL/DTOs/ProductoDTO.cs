using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panaderia.BL.DTOs
{
    public class ProductoDTO
    {
        public int IdProducto { get; set;}
        [Required]
        public string Nombre { get; set; }
        [Required]
        public double Precio { get; set; }
        [Required]
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; }
    }
}
