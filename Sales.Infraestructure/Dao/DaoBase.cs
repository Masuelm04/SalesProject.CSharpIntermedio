using Sales.Infraestructure.Core;
using Sales.Infraestructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Sales.Infraestructure.Dao
{
    public abstract class DaoBase<TEntity> : IDaoBase<TEntity> where TEntity : class
    {
        private readonly SalesContext context;
        private DbSet<TEntity> entities;
        public DaoBase(SalesContext context)
        {
            this.context = context;
            this.entities = context.Set<TEntity>();
        }
        public virtual bool Exists(Func<TEntity, bool> filter)
        {
            return this.entities.Any(filter);
        }
        public async virtual Task<List<TEntity>> GetAll()
        {
            return await this.entities.ToListAsync();
        }
        public async virtual Task<TEntity> GetById(int id)
        {
            return await this.entities.FindAsync(id);
        }
        public async virtual Task<DataResult> Save(TEntity entity)
        {
            DataResult result = new DataResult();

            this.entities.Add(entity);

            await this.Commit();

            result.Success = true;

            return result;
        }
        public async virtual Task<List<TEntity>> GetEntitiesWithFilters(Func<TEntity, bool> filter)
        {
            return this.entities.Where(filter).ToList();
        }
        public async virtual Task<DataResult> Update(TEntity entity)
        {
            DataResult result = new DataResult();

            this.entities.Update(entity);

            await this.Commit();

            result.Success = true;

            return result;
        }
        public async Task<int> Commit()
        {
            return await this.context.SaveChangesAsync();
        }
    }
}
