using Panaderia.BL.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Threading.Tasks;

namespace Panaderia.BL.Repositories.Implements
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly PanaderiaContext panaderiaContext;

        public GenericRepository(PanaderiaContext panaderiaContext)
        {
            this.panaderiaContext = panaderiaContext;
        }

        public async Task Delete(int id)
        {
            var entity = await GetById(id);

            if (entity == null)
                throw new Exception("The entity is null");

            panaderiaContext.Set<TEntity>().Remove(entity);
            await panaderiaContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await panaderiaContext.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await panaderiaContext.Set<TEntity>().FindAsync(id);
        }

        public async Task<TEntity> Insert(TEntity entity)
        {
            panaderiaContext.Set<TEntity>().Add(entity);
            await panaderiaContext.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            //panaderiaContext.Entry(entity).State = EntityState.Modified;
            panaderiaContext.Set<TEntity>().AddOrUpdate(entity);
            await panaderiaContext.SaveChangesAsync();
            return entity;
        }
    }
}
