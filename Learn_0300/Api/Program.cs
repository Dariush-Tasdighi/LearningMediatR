using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

var builder =
	Microsoft.AspNetCore.Builder
	.WebApplication.CreateBuilder(args);

// AddControllers() -> using Microsoft.Extensions.DependencyInjection;
builder.Services.AddControllers();

// AddMediatR() -> using MediatR;
builder.Services.AddMediatR
	(handlerAssemblyMarkerTypes: typeof(Program));

var app =
	builder.Build();

// UseHttpsRedirection() -> using Microsoft.AspNetCore.Builder;
app.UseHttpsRedirection();

// MapControllers() -> using Microsoft.AspNetCore.Builder;
app.MapControllers();

app.Run();
