namespace Api.Commands.DoSomething01;

public record DoSomething01Command
	(string SomeProperty) : object, Dtat.Framework.Abstractions.ICommand;
