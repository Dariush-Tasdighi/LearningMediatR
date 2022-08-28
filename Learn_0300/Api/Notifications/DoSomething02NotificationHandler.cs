namespace Api.Notifications;

public class DoSomething02NotificationHandler : object,
	Framework.Abstractions.IEventHandler<DoSomethingNotification>
{
	public DoSomething02NotificationHandler() : base()
	{
	}

	public async System.Threading.Tasks.Task Handle
		(DoSomethingNotification notification,
		System.Threading.CancellationToken cancellationToken)
	{
		await System.Threading.Tasks.Task.Run(() =>
		{
			string message =
				$"{ToString()} - {notification.SomeProperty.ToUpper()}";

			System.Console.WriteLine(value: message);
			System.Diagnostics.Debug.WriteLine(value: message);
		});
	}
}
