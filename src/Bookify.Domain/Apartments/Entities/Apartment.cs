using Bookify.Domain.Abstractions.Entities;
using Bookify.Domain.Apartments.Enums;
using Bookify.Domain.Apartments.ValueObjects;
using Bookify.Domain.Shared.ValueObjects;

namespace Bookify.Domain.Apartments.Entities;

public sealed class Apartment : Entity
{
    public Apartment(Guid id, EntityName name, EntityDescription description, Address address,
        Money price, Money cleaningFee, List<Amenity> amenities) : base(id)
    {
        Name = name;
        Description = description;
        Address = address;
        Price = price;
        CleaningFee = cleaningFee;
        Amenities = amenities;
    }

    public EntityName Name { get; private set; }

    public EntityDescription Description { get; private set; }

    public Address Address { get; private set; }

    public Money Price { get; private set; }

    public Money CleaningFee { get; private set; }

    public DateTime? LastBookedOnUtc { get; internal set; }

    public List<Amenity> Amenities { get; private set; } = [];
}
