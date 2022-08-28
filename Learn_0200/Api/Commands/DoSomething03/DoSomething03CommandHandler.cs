namespace Api.Commands.DoSomething03;

public class DoSomething03CommandHandler :
	MediatR.RequestHandler<DoSomething03Command, string>
{
	public DoSomething03CommandHandler() : base()
	{
	}

	protected override string Handle
		(DoSomething03Command request)
	{
		var result =
			request.SomeProperty.ToUpper();

		System.Console.WriteLine(value: result);
		System.Diagnostics.Debug.WriteLine(value: result);

		return result;
	}
}
