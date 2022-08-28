namespace Api.Commands.DoSomething04;

public class DoSomething04CommandHandler :
	object, MediatR.IRequestHandler<DoSomething04Command, string>
{
	public DoSomething04CommandHandler() : base()
	{
	}

	public async System.Threading.Tasks.Task<string> Handle
		(DoSomething04Command request,
		System.Threading.CancellationToken cancellationToken)
	{
		var result =
			string.Empty;

		await System.Threading.Tasks.Task.Run(() =>
		{
			result =
				request.SomeProperty.ToUpper();

			System.Console.WriteLine(value: result);
			System.Diagnostics.Debug.WriteLine(value: result);
		});

		return result;
	}
}
