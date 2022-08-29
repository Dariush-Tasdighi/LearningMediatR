namespace Dtat.Framework;

public abstract class CommandHandlerBase<TCommand> :
	object, Abstractions.ICommandHandler<TCommand> where TCommand : Abstractions.ICommand
{
	public CommandHandlerBase() : base()
	{
	}

	[System.Obsolete]
	public async System.Threading.Tasks.Task<FluentResults.Result> Handle
		(TCommand command, System.Threading.CancellationToken cancellationToken = default)
	{
		var result =
			await
			HandleAsync(command, cancellationToken);

		return result;
	}

	public abstract System.Threading.Tasks.Task<FluentResults.Result> HandleAsync
		(TCommand command, System.Threading.CancellationToken cancellationToken = default);
}

public abstract class CommandHandlerBase<TCommand, TResult> :
	object, Abstractions.ICommandHandler<TCommand, TResult> where TCommand : Abstractions.ICommand<TResult>
{
	public CommandHandlerBase() : base()
	{
	}

	public async System.Threading.Tasks.Task<FluentResults.Result<TResult>>
		Handle(TCommand command, System.Threading.CancellationToken cancellationToken = default)
	{
		var result =
			await
			HandleAsync(command, cancellationToken);

		return result;
	}

	public abstract System.Threading.Tasks.Task<FluentResults.Result<TResult>>
		HandleAsync(TCommand command, System.Threading.CancellationToken cancellationToken = default);
}
