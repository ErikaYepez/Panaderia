﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panaderia.BL.DTOs
{
    public class OrdenDTO
    {
        public int IdOrden { get; set; }
        [Required]
        public int IdCliente { get; set; }
        public DateTime Fecha { get; set; }
        [Required]
        public int IdMetodoPago { get; set; }
        [Required]
        public int IdProducto { get; set; }
        [Required]
        public int Cantidad { get; set; }
        [Required]
        public float ValorTotal { get; set; }

       // public ClienteDTO Cliente { get; set; }
        //public MetodoPagoDTO MetodoPago { get; set; }
        //public ProductoDTO Producto { get; set; }

    }
}