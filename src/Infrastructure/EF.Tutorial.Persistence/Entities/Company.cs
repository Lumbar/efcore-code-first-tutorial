namespace EF.Tutorial.Persistence.Entities;

public class Company
{
    public Guid Id { get; set; }
    public string Code { get; set; } = default!;
    public string LegalName { get; set; } = default!;

    public DateTimeOffset CreatedAt { get; set; }
    public string? CreatedUser { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
    public string? UpdatedUser { get; set; }
    public DateTimeOffset? DeletedAt { get; set; }

    public ICollection<UserCompanyAccess> UserCompanyAccesses { get; set; } = new List<UserCompanyAccess>();
}
