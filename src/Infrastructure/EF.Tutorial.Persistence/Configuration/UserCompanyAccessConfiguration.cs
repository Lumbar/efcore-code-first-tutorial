using EF.Tutorial.Persistence.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF.Tutorial.Persistence.Configuration;

public class UserCompanyAccessConfiguration : IEntityTypeConfiguration<UserCompanyAccess>
{
    public void Configure(EntityTypeBuilder<UserCompanyAccess> builder)
    {
        builder.ToTable("UserCompanyAccess");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.UserId)
            .IsRequired();

        builder.Property(x => x.CompanyId)
            .IsRequired();

        builder
            .HasIndex(x => new { x.UserId, x.CompanyId })
            .IsUnique()
            .HasDatabaseName("USERCOMPANYACCESS_UQ1")
            .HasFilter("\"DeletedAt\" IS NULL");

        // FK -> User
        builder.HasOne(x => x.User)
            .WithMany(x => x.UserCompanyAccesses)
            .HasForeignKey(x => x.UserId)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("USERCOMPANYACCESS_USER_FK");

        // FK -> Company
        builder.HasOne(x => x.Company)
            .WithMany(x => x.UserCompanyAccesses)
            .HasForeignKey(x => x.CompanyId)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("USERCOMPANYACCESS_COMPANY_FK");

        builder.Property(c => c.CreatedUser)
            .HasMaxLength(100);

        builder.Property(c => c.UpdatedUser)
            .HasMaxLength(100);

        builder.Property(x => x.CreatedAt)
           .HasColumnType("timestamptz")
           .HasDefaultValueSql("now()");

        builder.Property(x => x.UpdatedAt)
            .HasColumnType("timestamptz");

        builder.Property(x => x.DeletedAt)
            .HasColumnType("timestamptz");
    }
}
