namespace Example.Api.Dto;

public sealed record Book 
{
    public required string Name { get; init; }
    
    public required int Price { get; init; }
    
    public required string Author { get; init; }
}