namespace Dtat.Framework;

public abstract class EventHandlerBase<TEvent> :
	object, Abstractions.IEventHandler<TEvent> where TEvent : Abstractions.IEvent
{
	public EventHandlerBase() : base()
	{
	}

	[System.Obsolete]
	public async System.Threading.Tasks.Task Handle
		(TEvent @event, System.Threading.CancellationToken cancellationToken = default)
	{
		await System.Threading.Tasks.Task.FromResult
			(HandleAsync(@event: @event, cancellationToken: cancellationToken));
	}

	public abstract System.Threading.Tasks.Task HandleAsync
		(TEvent @event, System.Threading.CancellationToken cancellationToken = default);
}
