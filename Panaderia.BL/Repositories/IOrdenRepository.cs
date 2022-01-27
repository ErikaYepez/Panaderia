using Panaderia.BL.Models;
using System.Threading.Tasks;

namespace Panaderia.BL.Repositories
{
    public interface IOrdenRepository : IGenericRepository<Orden>
    {
        Task<bool> DeleteEntity(int id);
    }
}
