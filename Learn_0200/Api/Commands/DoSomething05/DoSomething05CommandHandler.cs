namespace Api.Commands.DoSomething01;

public class DoSomething05CommandHandler :
	object, MediatR.IRequestHandler<DoSomething05Command, FluentResults.Result>
{
	public DoSomething05CommandHandler() : base()
	{
	}

	public async System.Threading.Tasks.Task<FluentResults.Result>
		Handle(DoSomething05Command request,
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
