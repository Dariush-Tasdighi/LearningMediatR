namespace Dtat.Framework.Abstractions;

public interface ICommand : MediatR.IRequest<FluentResults.Result>
{
}

public interface ICommand<TResult> : MediatR.IRequest<FluentResults.Result<TResult>>
{
}
