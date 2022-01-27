using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Panaderia.BL.Models
{
    [Table("Orden", Schema = "dbo")]
    public class Orden
    {
        [Key]
        public int IdOrden { get; set; }
        [ForeignKey("Cliente")]
        public int IdCliente { get; set; }
        public DateTime Fecha { get; set; }
        [ForeignKey("MetodoPago")]
        public int IdMetodoPago { get; set; }
        [ForeignKey("Producto")]
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public double ValorTotal { get; set; }

        public Cliente Cliente { get; set; }
        public MetodoPago MetodoPago { get; set; }
        public Producto Producto { get; set; }

    }
}
