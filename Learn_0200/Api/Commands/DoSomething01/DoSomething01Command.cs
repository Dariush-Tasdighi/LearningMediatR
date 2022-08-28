namespace Api.Commands.DoSomething01;

/// <summary>
/// Command - Without Result - Sync
/// </summary>
public class DoSomething01Command : object, MediatR.IRequest
{
	public DoSomething01Command(string someProperty) : base()
	{
		SomeProperty = someProperty;
	}

	public string SomeProperty { get; }
}
