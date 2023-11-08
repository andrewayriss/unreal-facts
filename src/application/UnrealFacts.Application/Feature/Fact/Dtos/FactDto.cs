namespace UnrealFacts.Application.Feature.Fact.Dtos;

public record FactDto
{
    public int Id { get; }

    public string Fact { get; }

    public FactDto(int id, string fact)
    {
        Id = id;
        Fact = fact;
    }
}
