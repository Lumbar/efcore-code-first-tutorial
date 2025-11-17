namespace EF.Tutorial.Persistence.Entities;

public class User
{
    public Guid Id { get; set; }
    public string ExternalObjectId { get; set; } = default!;
    public string DisplayName { get; set; } = default!;
    public string Email { get; set; } = default!;

    public DateTimeOffset CreatedAt { get; set; }
    public string? CreatedUser { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
    public string? UpdatedUser { get; set; }
    public DateTimeOffset? DeletedAt { get; set; }

    public ICollection<UserCompanyAccess> UserCompanyAccesses { get; set; } = new List<UserCompanyAccess>();
}
