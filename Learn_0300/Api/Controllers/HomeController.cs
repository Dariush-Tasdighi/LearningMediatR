using FluentResults;

namespace Api.Controllers;

public class HomeController : Infrastructor.ControllerBase
{
	public HomeController(MediatR.IMediator mediator) : base(mediator: mediator)
	{
	}

	[Microsoft.AspNetCore.Mvc.HttpGet]
	public Microsoft.AspNetCore.Mvc.IActionResult Index()
	{
		var message =
			"Hello, World!";

		return Ok(value: new { Message = message });
	}

	/// <summary>
	/// https://localhost:7059/api/home/DoSomething01
	/// </summary>
	[Microsoft.AspNetCore.Mvc.HttpGet(template: "dosomething01")]
	public async System.Threading.Tasks.Task
		<Microsoft.AspNetCore.Mvc.IActionResult> DoSomething01()
	{
		var command =
			new Commands.DoSomething01
			.DoSomething01Command(SomeProperty: "Command (1)");

		var result =
			await
			Mediator.Send(request: command);

		if (result.IsSuccess)
		{
			return Ok(value: result);
		}
		else
		{
			return BadRequest(error: result.ToResult());
		}
	}

	/// <summary>
	/// https://localhost:7059/api/home/DoSomething02
	/// </summary>
	[Microsoft.AspNetCore.Mvc.HttpGet(template: "dosomething02")]
	public async System.Threading.Tasks.Task
		<Microsoft.AspNetCore.Mvc.IActionResult> DoSomething02()
	{
		var command =
			new Commands.DoSomething02
			.DoSomething02Command(SomeProperty: "Command (2)");

		var result =
			await
			Mediator.Send(request: command);

		if (result.IsSuccess)
		{
			return Ok(value: result);
		}
		else
		{
			return BadRequest(error: result.ToResult());
		}
	}

	///// <summary>
	///// https://localhost:7059/api/home/DoSomething02
	///// </summary>
	//[Microsoft.AspNetCore.Mvc.HttpGet(template: "dosomething02")]
	//public async System.Threading.Tasks.Task
	//	<Microsoft.AspNetCore.Mvc.IActionResult> DoSomething02()
	//{
	//	try
	//	{
	//		var notification = new Notifications
	//			.DoSomethingNotification(someProperty: "Notification Message");

	//		//await Mediator.Publish
	//		//	<Notifications.DoSomethingNotification>(notification: notification);

	//		// Simplified!
	//		await Mediator.Publish
	//			(notification: notification);

	//		return Ok(value: "OK");
	//	}
	//	catch (System.Exception ex)
	//	{
	//		return BadRequest(error: ex.Message);
	//	}
	//}
}
