namespace Api.Commands.DoSomething03;

/// <summary>
/// Command - With Result (string) - Sync
/// </summary>
public class DoSomething03Command : object, MediatR.IRequest<string>
{
	public DoSomething03Command(string someProperty) : base()
	{
		SomeProperty = someProperty;
	}

	public string SomeProperty { get; }
}
