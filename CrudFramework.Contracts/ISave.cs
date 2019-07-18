namespace CrudFramework.Contracts
{
    public interface ISave<TEntity>
    {
        /// <param name="entity"></param>
        void Save(TEntity entity);
    }
}
