namespace Infrastructor;

[Microsoft.AspNetCore.Mvc.ApiController]
[Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
public class ControllerBase : Microsoft.AspNetCore.Mvc.ControllerBase
{
	public ControllerBase(MediatR.IMediator mediator) : base()
	{
		Mediator = mediator;
	}

	protected MediatR.IMediator Mediator { get; }
}
