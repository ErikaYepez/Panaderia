using Panaderia.BL.Models;
using System.Threading.Tasks;

namespace Panaderia.BL.Services
{
    public interface IProductoService : IGenericService<Producto>
    {
        Task<bool> DeleteEntity(int id);
    }
}
