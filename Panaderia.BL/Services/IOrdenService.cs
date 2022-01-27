using Panaderia.BL.Models;
using System.Threading.Tasks;

namespace Panaderia.BL.Services
{
    public interface IOrdenService : IGenericService<Orden>
    {
        Task<bool> DeleteEntity(int id);
    }
}
