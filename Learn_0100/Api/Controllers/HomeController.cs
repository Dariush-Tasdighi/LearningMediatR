namespace Api.Controllers;

public class HomeController : Infrastructor.ControllerBase
{
	public HomeController() : base()
	{
	}

	[Microsoft.AspNetCore.Mvc.HttpGet]
	public Microsoft.AspNetCore.Mvc.IActionResult Index()
	{
		return Ok(value: new { Message = "Hello, World!" });
	}
}
