namespace Api.Notifications;

public record DoSomethingNotification
	(string SomeProperty) : Dtat.Framework.DomainEventBase;
