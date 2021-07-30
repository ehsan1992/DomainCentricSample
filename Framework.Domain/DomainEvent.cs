using System;

namespace Framework.Domain
{
    public abstract class DomainEvent
    {
        protected DomainEvent()
        {
            EventId = Guid.NewGuid();
            PublishDateTime = DateTime.Now;
        }
        public Guid EventId { get; private set; }
        public DateTime PublishDateTime { get; private set; }


    }
}