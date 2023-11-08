using UnrealFacts.Application.Feature.Fact.Dtos;

namespace UnrealFacts.Application.Feature.Fact;

public static class JunkData
{
    public static List<FactDto> Facts { get; } = new List<FactDto>()
    {
        new FactDto(1, "Onions rubbed onto bare feet can help a person levitate for up to 20 seconds."),
        new FactDto(2, "There are more atoms of Hydrogen in a single molecule of water than there are stars in the entire Solar system."),
        new FactDto(3, "Some horses can believe its not butter."),
    };
}