namespace Api.Commands.DoSomething02;

public record DoSomething02Command
	(string SomeProperty) : object, Dtat.Framework.Abstractions.ICommand<string>;
