using Panaderia.BL.Models;
using Panaderia.BL.Repositories;
using System.Threading.Tasks;

namespace Panaderia.BL.Services.Implements
{
    public class ProductoService : GenericService<Producto>, IProductoService
    {
        private readonly IProductoRepository productoRepository;
        public ProductoService(IProductoRepository productoRepository) : base(productoRepository)
        {
            this.productoRepository = productoRepository;

        }

        public async Task<bool> DeleteEntity(int id)
        {
            return await productoRepository.DeleteEntity(id);
        }
    }
}
