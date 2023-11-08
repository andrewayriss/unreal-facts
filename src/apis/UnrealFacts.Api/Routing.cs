using MediatR;
using System.Runtime.CompilerServices;
using UnrealFacts.Application.Feature.Fact.Queries;

namespace UnrealFacts.Api;

public static class Routing
{
    public static WebApplication AddRoutes(this WebApplication app)
    {
        app.MapGet("/", () => "Hello World!");
        app.MapGet("/random", async (IMediator mediator, CancellationToken cancellationToken) => await mediator.Send(new GetRandomFactQuery(), cancellationToken));
        app.MapGet("/fact/{id}", async (IMediator mediator, int id) => await mediator.Send(new GetFactQuery(id)));

        return app;
    }
}
