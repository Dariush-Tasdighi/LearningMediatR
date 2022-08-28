namespace Api.Commands.DoSomething01;

/// <summary>
/// Command - With Result (FluentResult) - FluentResult without Result - ASync
/// </summary>
public class DoSomething05Command :
	object, MediatR.IRequest<FluentResults.Result>
{
	public DoSomething05Command(string someProperty) : base()
	{
		SomeProperty = someProperty;
	}

	public string SomeProperty { get; }
}
