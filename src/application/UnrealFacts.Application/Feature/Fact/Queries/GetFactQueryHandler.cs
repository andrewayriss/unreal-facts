using MediatR;
using UnrealFacts.Application.Feature.Fact.Dtos;

namespace UnrealFacts.Application.Feature.Fact.Queries;

public class GetFactQueryHandler : IRequestHandler<GetFactQuery, FactDto>
{
    public Task<FactDto> Handle(GetFactQuery request, CancellationToken cancellationToken)
    {
        var fact = JunkData.Facts.Find(f => f.Id == request.Id)!;
        return Task.FromResult(fact);
    }
}
