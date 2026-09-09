using Awync.LMS.Domain.Common.Interfaces;
using Awync.LMS.Domain.Enums;
using Microsoft.AspNetCore.Identity;

namespace Awync.LMS.Domain.Entities;

public class User : IdentityUser<Guid>, IAuditableEntity, ISoftDelete
{
    public string FullName { get; set; } = string.Empty;
    public UserRole Role { get; set; } = UserRole.Student;
    public string? AvatarUrl { get; set; }

    // Audit fields 
    public DateTimeOffset CreatedAt { get; set; }
    public string? CreatedBy { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
    public string? UpdatedBy { get; set; }

    // Soft delete fields 
    public bool IsDeleted { get; set; } = false;
    public DateTimeOffset? DeletedAt { get; set; }

    // Navigation
    public virtual ICollection<RefreshToken> RefreshTokens { get; set; } = [];
}