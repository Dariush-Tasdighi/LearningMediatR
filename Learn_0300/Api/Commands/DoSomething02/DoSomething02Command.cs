namespace Api.Commands.DoSomething02;

public record DoSomething02Command(string SomeProperty) : Framework.Abstractions.ICommand<string>;
