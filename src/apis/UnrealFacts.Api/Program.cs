using Microsoft.OpenApi.Models;
using UnrealFacts.Api;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Unreal facts API", Description = "Complete untrue facts I've made up", Version = "v1" });
}); 

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(UnrealFacts.Application.Feature.Fact.Queries.GetFactQuery).Assembly));

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Unreal facts API V1");
});

app.AddRoutes();

app.Run();
