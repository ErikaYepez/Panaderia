using Panaderia.BL.Data;
using Panaderia.BL.Models;

namespace Panaderia.BL.Repositories.Implements
{
    public class DireccionRepository : GenericRepository<Direccion>
    {
        public DireccionRepository(PanaderiaContext panaderiaContext) : base(panaderiaContext)
        {

        }
    }
}
