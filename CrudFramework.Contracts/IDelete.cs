namespace CrudFramework.Contracts
{
    public interface IDelete<TEntity>
    {
        void Delete(TEntity entity);
    }
}
