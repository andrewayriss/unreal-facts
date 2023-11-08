using MediatR;
using UnrealFacts.Application.Feature.Fact.Dtos;

namespace UnrealFacts.Application.Feature.Fact.Queries;

public class GetFactQuery : IRequest<FactDto>
{
    public GetFactQuery(int id)
    {
        Id = id;
    }

    public int Id { get; }
}
