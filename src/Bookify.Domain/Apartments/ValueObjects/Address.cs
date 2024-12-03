namespace Bookify.Domain.Apartments.ValueObjects;

// Value Object

public sealed record Address(
    string Country,
    string State,
    string ZipCode,
    string City,
    string Street);
