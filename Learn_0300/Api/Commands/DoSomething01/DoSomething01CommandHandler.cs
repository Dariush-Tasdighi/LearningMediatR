namespace Api.Commands.DoSomething01;

public class DoSomething01CommandHandler :
	Dtat.Framework.CommandHandlerBase<DoSomething01Command>
{
	public DoSomething01CommandHandler() : base()
	{
	}

	public async override System.Threading.Tasks.Task<FluentResults.Result>
		HandleAsync(DoSomething01Command command,
		System.Threading.CancellationToken cancellationToken = default)
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
					command.SomeProperty.ToUpper();

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
