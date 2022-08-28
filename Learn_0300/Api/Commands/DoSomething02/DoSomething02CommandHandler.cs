namespace Api.Commands.DoSomething02;

public class DoSomething02CommandHandler :
	object, Framework.Abstractions.ICommandHandler<DoSomething02Command, string>
{
	public DoSomething02CommandHandler() : base()
	{
	}

	public async System.Threading.Tasks.Task<FluentResults.Result<string>> Handle
		(DoSomething02Command request,
		System.Threading.CancellationToken cancellationToken)
	{
		var result =
			new FluentResults.Result<string>();

		try
		{
			await System.Threading.Tasks.Task.Run(() =>
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

				result.WithValue(value: message);

				System.Console.WriteLine(value: message);
				System.Diagnostics.Debug.WriteLine(value: message);
				// **************************************************
			}, cancellationToken: cancellationToken);
		}
		catch (System.Exception ex)
		{
			// Log Error!

			result.WithError(errorMessage: ex.Message);
		}

		return result;
	}
}
