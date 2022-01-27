using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Panaderia.BL.Models
{
    [Table("Cliente", Schema ="dbo")]
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        [ForeignKey("Direccion")]
        public int IdDireccion { get; set; }

        public Direccion Direccion  { get; set; }

        public virtual ICollection<Orden> Ordenes { get; set; }
    }
}
