// **************************************************
//using Microsoft.AspNetCore.Builder;

//var builder =
//	Microsoft.AspNetCore.Builder
//	.WebApplication.CreateBuilder(args);

//var app =
//	builder.Build();

//// MapGet() -> using Microsoft.AspNetCore.Builder;
//app.MapGet("/", () => "Hello World!");

//app.Run();
// **************************************************

// **************************************************
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

var builder =
	Microsoft.AspNetCore.Builder
	.WebApplication.CreateBuilder(args);

// AddControllers() -> using Microsoft.Extensions.DependencyInjection;
builder.Services.AddControllers();

var app =
	builder.Build();

// UseHttpsRedirection() -> using Microsoft.AspNetCore.Builder;
app.UseHttpsRedirection();

// MapControllers() -> using Microsoft.AspNetCore.Builder;
app.MapControllers();

app.Run();
// **************************************************
