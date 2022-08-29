using FluentResults;

namespace Api.Controllers;

public class HomeController : Infrastructure.ControllerBase
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
	public Microsoft.AspNetCore.Mvc.IActionResult DoSomething01()
	{
		var command =
			new Commands.DoSomething01
			.DoSomething01Command(someProperty: "Command (1)");

		Mediator.Send(request: command);

		return Ok(value: "OK");
	}

	/// <summary>
	/// https://localhost:7059/api/home/DoSomething02
	/// </summary>
	[Microsoft.AspNetCore.Mvc.HttpGet(template: "dosomething02")]
	public Microsoft.AspNetCore.Mvc.IActionResult DoSomething02()
	{
		var command =
			new Commands.DoSomething02
			.DoSomething02Command(someProperty: "Command (2)");

		Mediator.Send(request: command);

		return Ok(value: "OK");
	}

	/// <summary>
	/// https://localhost:7059/api/home/DoSomething03_01
	/// </summary>
	[Microsoft.AspNetCore.Mvc.HttpGet(template: "dosomething03_01")]
	public Microsoft.AspNetCore.Mvc.IActionResult DoSomething03_01()
	{
		var command =
			new Commands.DoSomething03
			.DoSomething03Command(someProperty: "Command (3)");

		//var result =
		//	Mediator.Send<string>(request: command).Result;

		var result =
			Mediator.Send(request: command).Result;

		return Ok(value: result);
	}

	/// <summary>
	/// https://localhost:7059/api/home/DoSomething03_02
	/// </summary>
	[Microsoft.AspNetCore.Mvc.HttpGet(template: "dosomething03_02")]
	public async System.Threading.Tasks.Task
		<Microsoft.AspNetCore.Mvc.IActionResult> DoSomething03_02()
	{
		var command =
			new Commands.DoSomething03
			.DoSomething03Command(someProperty: "Command (3)");

		//var result =
		//	await
		//	Mediator.Send<string>(request: command);

		var result =
			await
			Mediator.Send(request: command);

		return Ok(value: result);
	}

	/// <summary>
	/// https://localhost:7059/api/home/DoSomething04
	/// </summary>
	[Microsoft.AspNetCore.Mvc.HttpGet(template: "dosomething04")]
	public async System.Threading.Tasks.Task
		<Microsoft.AspNetCore.Mvc.IActionResult> DoSomething04()
	{
		var command =
			new Commands.DoSomething04
			.DoSomething04Command(someProperty: "Command (4)");

		var result =
			await
			Mediator.Send(request: command);

		return Ok(value: result);
	}

	/// <summary>
	/// https://localhost:7059/api/home/DoSomething05
	/// </summary>
	[Microsoft.AspNetCore.Mvc.HttpGet(template: "dosomething05")]
	public async System.Threading.Tasks.Task
		<Microsoft.AspNetCore.Mvc.IActionResult> DoSomething05()
	{
		var command =
			new Commands.DoSomething01
			.DoSomething05Command(someProperty: "Command (5)");

		var result =
			await
			Mediator.Send(request: command);

		if (result.IsSuccess)
		{
			return Ok(value: result);
		}
		else
		{
			// Note!!!
			// Below code raise error! because:
			// var value = result.Value; // throws exception because result is in failed state
			//return BadRequest(error: result);

			// ToResult() -> using FluentResults;
			return BadRequest(error: result.ToResult());
		}
	}

	/// <summary>
	/// https://localhost:7059/api/home/DoSomething06
	/// </summary>
	[Microsoft.AspNetCore.Mvc.HttpGet(template: "dosomething06")]
	public async System.Threading.Tasks.Task
		<Microsoft.AspNetCore.Mvc.IActionResult> DoSomething06()
	{
		var command =
			new Commands.DoSomething02
			.DoSomething06Command(someProperty: "Command (6)");

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
	/// https://localhost:7059/api/home/DoSomething07
	/// </summary>
	[Microsoft.AspNetCore.Mvc.HttpGet(template: "dosomething07")]
	public async System.Threading.Tasks.Task
		<Microsoft.AspNetCore.Mvc.IActionResult> DoSomething07()
	{
		try
		{
			var notification = new Notifications
				.DoSomethingNotification(someProperty: "Notification Message");

			//await Mediator.Publish
			//	<Notifications.DoSomethingNotification>(notification: notification);

			// Simplified!
			await Mediator.Publish
				(notification: notification);

			return Ok(value: "OK");
		}
		catch (System.Exception ex)
		{
			return BadRequest(error: ex.Message);
		}
	}
}
