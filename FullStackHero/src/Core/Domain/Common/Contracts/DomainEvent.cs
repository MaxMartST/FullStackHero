using FullStackHero.Shared.Events;

namespace FullStackHero.Domain.Common.Contracts;
public abstract class DomainEvent : IEvent
{
    public DateTime TriggeredOn { get; protected set; } = DateTime.UtcNow;
}