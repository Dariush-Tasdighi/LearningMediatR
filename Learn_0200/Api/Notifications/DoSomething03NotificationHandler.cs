namespace Api.Notifications;

public class DoSomething03NotificationHandler :
	object, MediatR.INotificationHandler<DoSomethingNotification>
{
	public DoSomething03NotificationHandler() : base()
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

		// مهم
		// وجود این خطا در قسمتی که انتشار صورت گرفته است اثری ندارد
		throw new System.Exception(message: "Some Error Message!");
	}
}
