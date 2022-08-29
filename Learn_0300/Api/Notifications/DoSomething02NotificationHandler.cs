namespace Api.Notifications;

public class DoSomething02NotificationHandler :
	Dtat.Framework.EventHandlerBase<DoSomethingNotification>
{
	public DoSomething02NotificationHandler() : base()
	{
	}

	public async override System.Threading.Tasks.Task HandleAsync
		(DoSomethingNotification notification,
		System.Threading.CancellationToken cancellationToken = default)
	{
		await System.Threading.Tasks.Task.Run(() =>
		{
			string message =
				$"{ToString()} - {notification.SomeProperty.ToUpper()}";

			System.Console.WriteLine(value: message);
			System.Diagnostics.Debug.WriteLine(value: message);
		}, cancellationToken: cancellationToken);
	}
}
