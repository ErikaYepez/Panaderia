using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Panaderia.BL.Models
{
    [Table("Direccion", Schema = "dbo")]
    public class Direccion
    {
        [Key]
        public int IdDireccion { get; set; }
        public string Detalle { get; set; }

        public virtual ICollection<Cliente> Clientes { get; set; }
    }
}
