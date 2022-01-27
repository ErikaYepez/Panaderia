using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Panaderia.BL.Models
{
    [Table("MetodoPago", Schema = "dbo")]

    public class MetodoPago
    {
        [Key]
        public int IdMetodoPago { get; set; }
        public string Detalle { get; set; }

        public virtual ICollection<Orden> Ordenes { set; get; }
    }
}
