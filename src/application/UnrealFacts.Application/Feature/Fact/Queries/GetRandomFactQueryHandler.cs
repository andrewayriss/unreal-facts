using MediatR;
using UnrealFacts.Application.Feature.Fact.Dtos;

namespace UnrealFacts.Application.Feature.Fact.Queries;

public class GetRandomFactQueryHandler : IRequestHandler<GetRandomFactQuery, FactDto>
{
    public Task<FactDto> Handle(GetRandomFactQuery request, CancellationToken cancellationToken)
    {
        var random = new Random();
        var id = random.Next(1, JunkData.Facts.Count + 1);

        var fact = JunkData.Facts.Find(f => f.Id == id)!;
        return Task.FromResult(fact);
    }
}
