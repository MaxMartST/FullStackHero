using FullStackHero.Shared.Events;

namespace FullStackHero.Application.Common.Events;
public class EventNotification<TEvent> : INotification
    where TEvent : IEvent
{
    public EventNotification(TEvent @event) => Event = @event;

    public TEvent Event { get; }
}