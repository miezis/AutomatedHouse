namespace AutomatedHouse.ServiceContracts
{
    public interface IGenericServiceBase<TEntity>
    {
        TEntity GetById(int id);

        TEntity Add(TEntity entity);

        void Delete(TEntity entity);

        void Update(TEntity entity);
    }
}
