using AutomatedHouse.DataContracts;
using AutomatedHouse.DataEntities;
using System.Data.Entity;
using System.Linq;

namespace AutomatedHouse.Data
{
    public abstract class GenericRepositoryBase<TEntity> : IGenericRepository<TEntity> 
        where TEntity : class, IEntity
    {
        protected readonly DbContext DbContext;

        protected GenericRepositoryBase(DbContext dbContext)
        {
            DbContext = dbContext;
        }

        public virtual TEntity GetById(int id)
        {
            return DbContext.Set<TEntity>().SingleOrDefault(entity => entity.Id == id);
        }

        public virtual TEntity Add(TEntity entity)
        {
            var newEntity = DbContext.Set<TEntity>().Add(entity);
            DbContext.SaveChanges();

            return newEntity;
        }

        public virtual TEntity Delete(TEntity entity)
        {
            var deletedEntity = DbContext.Set<TEntity>().Remove(entity);
            DbContext.SaveChanges();

            return deletedEntity;
        }

        public virtual void Update(TEntity entity)
        {
            DbContext.Entry(entity).State = EntityState.Modified;
            DbContext.SaveChanges();
        }
    }
}
