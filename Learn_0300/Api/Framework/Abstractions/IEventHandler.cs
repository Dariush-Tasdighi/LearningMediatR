namespace Framework.Abstractions;

public interface IEventHandler<TEvent> :
	MediatR.INotificationHandler<TEvent>
	where TEvent : IEvent
{
}
