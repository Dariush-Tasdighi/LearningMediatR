namespace Api.Commands.DoSomething01;

public class DoSomething01CommandHandler :
	object, Framework.Abstractions.ICommandHandler<DoSomething01Command>
{
	public DoSomething01CommandHandler() : base()
	{
	}

	public async System.Threading.Tasks.Task<FluentResults.Result>
		Handle(DoSomething01Command request,
		System.Threading.CancellationToken cancellationToken)
	{
		var result =
			new FluentResults.Result();

		try
		{
			await System.Threading.Tasks.Task.Run((System.Action)(() =>
			{
				// **************************************************
				//throw new System.Exception(message: "Some Error!");
				// **************************************************

				// **************************************************
				var message =
					request.SomeProperty.ToUpper();

				result.WithSuccess
					(successMessage: "Success Message (1)");

				result.WithSuccess
					(successMessage: "Success Message (2)");

				System.Console.WriteLine(value: message);
				System.Diagnostics.Debug.WriteLine(value: message);
				// **************************************************
			}), cancellationToken: cancellationToken);
		}
		catch (System.Exception ex)
		{
			// Log Error!

			result.WithError
				(errorMessage: ex.Message);
		}

		return result;
	}
}
