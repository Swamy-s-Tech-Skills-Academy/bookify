﻿using Bookify.Domain.Abstractions;

namespace Bookify.Domain.Apartments;

public sealed class Apartment : Entity
{
    public Apartment(Guid id) : base(id)
    {
    }

    public string Name { get; private set; } = string.Empty;

    public string Description { get; private set; } = string.Empty;

    public Address Address { get; private set; }

    public decimal PriceAmount { get; private set; }

    public string PriceCurrency { get; private set; } = string.Empty;

    public decimal CleaningFeeAmount { get; private set; }

    public string CleaningFeeCurrency { get; private set; } = string.Empty;

    public DateTime? LastBookedOnUtc { get; internal set; }

    public List<Amenity> Amenities { get; private set; } = [];
}
