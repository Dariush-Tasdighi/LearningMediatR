namespace Api.Notifications;

public record DoSomethingNotification
	(string SomeProperty) : object, Framework.Abstractions.IDomainEvent;
