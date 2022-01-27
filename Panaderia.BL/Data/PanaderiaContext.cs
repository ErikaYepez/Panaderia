using Panaderia.BL.Models;
using System.Data.Entity;

namespace Panaderia.BL.Data
{
    public class PanaderiaContext :DbContext
    {
        //private static PanaderiaContext panaderiaContext = null;
        public PanaderiaContext()
            :base("PanaderiaContext")
        {

        }

        public DbSet<Cliente> Clientes { set; get; }
        public DbSet<Direccion> Direcciones  { set; get; }
        public DbSet<Producto> Productos { set; get; }
        public DbSet<MetodoPago> MetodoPagos { set; get; }
        public DbSet<Orden> Ordenes { set; get; }
       
        public static PanaderiaContext Create()
        {
           // if (panaderiaContext == null)
             //   panaderiaContext = new PanaderiaContext();

            return new PanaderiaContext(); ;    
        }


    }
}
