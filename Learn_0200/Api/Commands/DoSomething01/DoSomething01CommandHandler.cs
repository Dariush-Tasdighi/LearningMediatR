namespace Api.Commands.DoSomething01;

public class DoSomething01CommandHandler :
	MediatR.RequestHandler<DoSomething01Command>
{
	public DoSomething01CommandHandler() : base()
	{
	}

	protected override void Handle
		(DoSomething01Command request)
	{
		var result =
			request.SomeProperty.ToUpper();

		System.Console.WriteLine(value: result);
		System.Diagnostics.Debug.WriteLine(value: result);
	}
}
