using Panaderia.BL.Data;
using Panaderia.BL.Models;
using System.Data.Entity;
using System.Threading.Tasks;

namespace Panaderia.BL.Repositories.Implements
{
    public class ProductoRepository : GenericRepository<Producto>, IProductoRepository
    {
        private readonly PanaderiaContext panaderiaContext;
        public ProductoRepository(PanaderiaContext panaderiaContext) : base(panaderiaContext)
        {
            this.panaderiaContext = panaderiaContext;
        }

        public async Task<bool> DeleteEntity(int id)
        {
            var flag = await panaderiaContext.Ordenes.AnyAsync(x => x.IdCliente == id);
            return flag;
        }
    }
}
