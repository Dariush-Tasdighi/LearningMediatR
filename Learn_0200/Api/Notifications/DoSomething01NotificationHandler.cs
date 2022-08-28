namespace Api.Notifications;

public class DoSomething01NotificationHandler :
	object, MediatR.INotificationHandler<DoSomethingNotification>
{
	public DoSomething01NotificationHandler() : base()
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
		}, cancellationToken: cancellationToken);
	}
}
