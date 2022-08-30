namespace Dtat.Framework;

public record CommandBase : object, Abstractions.ICommand;

public record CommandBase<TResult> : object, Abstractions.ICommand<TResult>;
