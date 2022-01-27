using Panaderia.BL.Models;
using System.Threading.Tasks;

namespace Panaderia.BL.Services
{
    public interface IClienteService : IGenericService<Cliente>
    {
        Task<bool> DeleteEntity(int id);
    }
}
