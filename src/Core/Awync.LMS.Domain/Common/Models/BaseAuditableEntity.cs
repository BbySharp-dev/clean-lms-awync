using Awync.LMS.Domain.Common.Interfaces;

namespace Awync.LMS.Domain.Common.Models;

public abstract class BaseAuditableEntity : BaseEntity, IAuditableEntity, ISoftDelete
{
    public DateTimeOffset CreatedAt { get; set; }
    public string? CreatedBy { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
    public string? UpdatedBy { get; set; }
    
    public bool IsDeleted { get; set; } = false;
    public DateTimeOffset? DeletedAt { get; set; }
}