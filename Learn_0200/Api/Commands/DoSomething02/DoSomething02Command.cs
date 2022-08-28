namespace Api.Commands.DoSomething02;

/// <summary>
/// Command - Without Result - ASync
/// </summary>
public class DoSomething02Command : object, MediatR.IRequest
{
	public DoSomething02Command(string someProperty) : base()
	{
		SomeProperty = someProperty;
	}

	public string SomeProperty { get; }
}
