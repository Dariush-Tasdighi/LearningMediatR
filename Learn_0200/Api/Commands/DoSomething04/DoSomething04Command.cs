namespace Api.Commands.DoSomething04;

/// <summary>
/// Command - With Result (string) - ASync
/// </summary>
public class DoSomething04Command : object, MediatR.IRequest<string>
{
	public DoSomething04Command(string someProperty) : base()
	{
		SomeProperty = someProperty;
	}

	public string SomeProperty { get; }
}
