using Panaderia.BL.Models;
using Panaderia.BL.Repositories;

namespace Panaderia.BL.Services.Implements
{
    public class MetodoPagoService : GenericService<MetodoPago>
    {
        public MetodoPagoService(IMetodoPagoRepository metodoRepository) : base(metodoRepository)
        {

        }
    }
}
