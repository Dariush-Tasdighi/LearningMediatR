namespace Api.Notifications;

public class DoSomethingNotification : object, MediatR.INotification
{
	public DoSomethingNotification(string someProperty) : base()
	{
		SomeProperty = someProperty;
	}

	public string SomeProperty { get; }
}
