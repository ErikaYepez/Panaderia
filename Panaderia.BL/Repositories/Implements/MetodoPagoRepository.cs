using Panaderia.BL.Data;
using Panaderia.BL.Models;

namespace Panaderia.BL.Repositories.Implements
{
    public class MetodoPagoRepository : GenericRepository<MetodoPago>
    {
        public MetodoPagoRepository(PanaderiaContext panaderiaContext) : base(panaderiaContext)
        {

        }
    }
}
