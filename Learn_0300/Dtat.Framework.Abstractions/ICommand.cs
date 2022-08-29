namespace Dtat.Framework.Abstractions;

public interface ICommand : MediatR.IRequest<FluentResults.Result>
{
}

public interface ICommand<TValue> : MediatR.IRequest<FluentResults.Result<TValue>>
{
}
