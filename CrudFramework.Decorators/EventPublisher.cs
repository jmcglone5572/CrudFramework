using System;
using CrudFramework.Contracts;

namespace CrudFramework.DecoratorClasses
{
    public class EventPublisher<TEntity> : IEventPublisher
    {
        public void Publish<TEvent>(TEvent @event) where TEvent : IEvent
        {
        }
    }
}
