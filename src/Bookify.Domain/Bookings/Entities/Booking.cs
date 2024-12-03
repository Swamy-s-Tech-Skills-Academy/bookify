using Bookify.Domain.Abstractions.Entities;

namespace Bookify.Domain.Bookings.Entities;

public sealed class Booking : Entity
{

    public Booking(Guid id) : base(id)
    {
    }
}
