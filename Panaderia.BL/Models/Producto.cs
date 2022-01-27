using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Panaderia.BL.Models
{
    [Table("Producto", Schema = "dbo")]

    public class Producto
    {
        [Key]
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; }

        public virtual ICollection<Orden> Ordenes { set; get; }

    }
}
