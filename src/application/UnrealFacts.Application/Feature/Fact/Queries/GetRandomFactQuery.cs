using MediatR;
using UnrealFacts.Application.Feature.Fact.Dtos;

namespace UnrealFacts.Application.Feature.Fact.Queries;

public class GetRandomFactQuery : IRequest<FactDto>
{
}
