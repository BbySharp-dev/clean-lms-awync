namespace Awync.LMS.Domain.Common.Interfaces;

public interface ISoftDelete
{
    bool IsDeleted { get; set; }
    DateTimeOffset? DeletedAt { get; set; }
}
