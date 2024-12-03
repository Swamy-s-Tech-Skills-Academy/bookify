using Bookify.Domain.Abstractions;

namespace Bookify.Domain.Users.Entities;

public sealed class User : Entity
{
    public User(Guid id) : base(id) 
    {
    }
}
