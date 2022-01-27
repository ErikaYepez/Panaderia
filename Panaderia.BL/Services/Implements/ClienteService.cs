using Panaderia.BL.Models;
using Panaderia.BL.Repositories;
using System.Threading.Tasks;

namespace Panaderia.BL.Services.Implements
{
    public class ClienteService : GenericService<Cliente>, IClienteService
    {
        private readonly IClienteRepository clienteRepository;
        public ClienteService(IClienteRepository clienteRepository) : base(clienteRepository)
        {
            this.clienteRepository = clienteRepository;

        }

        public async Task<bool> DeleteEntity(int id)
        {
            return await clienteRepository.DeleteEntity(id);
        }
    }
}
