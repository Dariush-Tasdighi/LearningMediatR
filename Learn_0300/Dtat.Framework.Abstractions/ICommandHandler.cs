namespace Dtat.Framework.Abstractions;

public interface ICommandHandler<TCommand> :
	MediatR.IRequestHandler<TCommand, FluentResults.Result>
	where TCommand : ICommand
{
}

public interface ICommandHandler<in TCommand, TValue> :
	MediatR.IRequestHandler<TCommand, FluentResults.Result<TValue>>
	where TCommand : ICommand<TValue>
{
}
