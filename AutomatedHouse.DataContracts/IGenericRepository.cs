using AutomatedHouse.DataEntities;

namespace AutomatedHouse.DataContracts
{
    public interface IGenericRepository<TEntity>
        where TEntity : class, IEntity
    {
        TEntity GetById(int id);

        TEntity Add(TEntity entity);

        TEntity Delete(TEntity entity);

        void Update(TEntity entity);
    }
}
