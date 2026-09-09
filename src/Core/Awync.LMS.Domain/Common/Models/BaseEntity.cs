namespace Awync.LMS.Domain.Common.Models;

public abstract class BaseEntity
{
    public Guid Id { get; protected set; } = Guid.NewGuid();
}
