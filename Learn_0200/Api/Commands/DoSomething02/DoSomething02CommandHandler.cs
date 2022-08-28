namespace Api.Commands.DoSomething02;

public class DoSomething02CommandHandler :
	object, MediatR.IRequestHandler<DoSomething02Command>
{
	public DoSomething02CommandHandler() : base()
	{
	}

	public async System.Threading.Tasks.Task<MediatR.Unit> Handle
		(DoSomething02Command request,
		System.Threading.CancellationToken cancellationToken)
	{
		await System.Threading.Tasks.Task.Run(() =>
		{
			var result =
				request.SomeProperty.ToUpper();

			System.Console.WriteLine(value: result);
			System.Diagnostics.Debug.WriteLine(value: result);
		});

		return MediatR.Unit.Value;
	}
}
