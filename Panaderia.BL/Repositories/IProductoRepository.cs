using Panaderia.BL.Models;
using System.Threading.Tasks;

namespace Panaderia.BL.Repositories
{
    public interface IProductoRepository : IGenericRepository<Producto>
    {
        Task<bool> DeleteEntity(int id);
    }
}
