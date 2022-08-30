namespace Api.Commands.DoSomething02;

public record DoSomething02Command
	(string SomeProperty) : Dtat.Framework.CommandBase<string>;
