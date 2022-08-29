namespace Api.Notifications;

public record DoSomethingNotification
	(string SomeProperty) : object, Dtat.Framework.Abstractions.IDomainEvent;
