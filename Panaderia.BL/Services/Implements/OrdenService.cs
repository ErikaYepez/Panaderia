using Panaderia.BL.Models;
using Panaderia.BL.Repositories;
using System.Threading.Tasks;

namespace Panaderia.BL.Services.Implements
{
    public class OrdenService : GenericService<Orden>, IOrdenService
    {
        private readonly IOrdenRepository ordenRepository;
        public OrdenService(IOrdenRepository ordenRepository) : base(ordenRepository)
        {
            this.ordenRepository = ordenRepository;

        }

        public async Task<bool> DeleteEntity(int id)
        {
            return await ordenRepository.DeleteEntity(id);
        }
    }
}
