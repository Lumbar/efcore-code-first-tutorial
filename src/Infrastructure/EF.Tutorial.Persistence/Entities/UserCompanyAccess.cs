namespace EF.Tutorial.Persistence.Entities;

public class UserCompanyAccess
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public Guid CompanyId { get; set; }

    public DateTimeOffset CreatedAt { get; set; }
    public string? CreatedUser { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
    public string? UpdatedUser { get; set; }
    public DateTimeOffset? DeletedAt { get; set; }

    public User User { get; set; } = default!;
    public Company Company { get; set; } = default!;
}
