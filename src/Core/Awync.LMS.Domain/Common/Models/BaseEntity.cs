namespace Awync.LMS.Domain.Common.Models;

public abstract class BaseEntity
{
    //TODO HasDefaultValueSql("NEWSEQUENTIALID()")
    public Guid Id { get; protected set; } = Guid.NewGuid();
}
