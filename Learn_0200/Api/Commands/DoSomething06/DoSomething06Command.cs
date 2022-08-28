namespace Api.Commands.DoSomething02;

/// <summary>
/// Command - With Result (FluentResult) - FluentResult with Result (string) - ASync
/// </summary>
public class DoSomething06Command :
	object, MediatR.IRequest<FluentResults.Result<string>>
{
	public DoSomething06Command(string someProperty) : base()
	{
		SomeProperty = someProperty;
	}

	public string SomeProperty { get; }
}
