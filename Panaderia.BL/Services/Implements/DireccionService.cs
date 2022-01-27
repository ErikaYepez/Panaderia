using Panaderia.BL.Models;
using Panaderia.BL.Repositories;

namespace Panaderia.BL.Services.Implements
{
    public class DireccionService : GenericService<Direccion>
    {
        public DireccionService(IDireccionRepository direccionRepository) : base(direccionRepository)
        {

        }
    }
}
