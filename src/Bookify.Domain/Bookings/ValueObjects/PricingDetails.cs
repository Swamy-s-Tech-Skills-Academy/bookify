using Bookify.Domain.Shared.ValueObjects;

namespace Bookify.Domain.Bookings.ValueObjects;

public sealed record PricingDetails(
    Money PriceForPeriod,
    Money CleaningFee,
    Money AmenitiesUpCharge,
    Money TotalPrice);
