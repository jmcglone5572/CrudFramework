namespace CrudFramework.Contracts
{
    public class EntityDeletedEvent<TEntity> : IEvent
    {
        public EntityDeletedEvent(TEntity entity)
        {
            DeletedEntity = entity;
        }

        public string Name
        {
            get { return "EntityDeleted"; }
        }

        public TEntity DeletedEntity
        {
            get;
            set;
        }
    }
}
