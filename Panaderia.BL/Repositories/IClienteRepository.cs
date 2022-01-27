using Panaderia.BL.Models;
using System.Threading.Tasks;

namespace Panaderia.BL.Repositories
{
    public interface IClienteRepository:IGenericRepository<Cliente>
    {
        Task<bool> DeleteEntity(int id);
    }
}
