using System.Collections.Generic;

namespace Framework.Domain
{
    public abstract class AggregateRoot<T> : Entity<T>
    {
        private readonly List<DomainEvent> _uncommittedEvents = new List<DomainEvent>();

        protected void Causes(DomainEvent domainEvent)
        {
            _uncommittedEvents.Add(domainEvent);
        }
    }
}