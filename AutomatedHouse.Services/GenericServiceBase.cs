using AutomatedHouse.DataContracts;
using AutomatedHouse.DataEntities;
using AutomatedHouse.ServiceContracts;

namespace AutomatedHouse.Services
{
    public abstract class GenericServiceBase<TRepository, TEntity> : IGenericServiceBase<TEntity>
        where TRepository : IGenericRepository<TEntity>
        where TEntity : class, IEntity
    {
        private readonly TRepository Repository;

        public GenericServiceBase(TRepository repository)
        {
            Repository = repository;
        }

        public virtual TEntity Add(TEntity entity)
        {
            var newEntity = Repository.Add(entity);

            return newEntity;
        }

        public virtual void Delete(TEntity entity)
        {
            Repository.Add(entity);
        }

        public virtual void Update(TEntity entity)
        {
            Repository.Update(entity);
        }

        public virtual TEntity GetById(int id)
        {
            var entity = Repository.GetById(id);

            return entity;
        }
    }
}
