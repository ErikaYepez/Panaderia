using Panaderia.BL.Data;
using Panaderia.BL.Models;
using System.Data.Entity;
using System.Threading.Tasks;

namespace Panaderia.BL.Repositories.Implements
{
    public class OrdenRepository : GenericRepository<Orden>,IOrdenRepository
    {
        private readonly PanaderiaContext panaderiaContext;
        public OrdenRepository(PanaderiaContext panaderiaContext) : base(panaderiaContext)
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
