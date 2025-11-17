using EF.Tutorial.Persistence.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF.Tutorial.Persistence.Configuration;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("User");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Email)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(c => c.ExternalObjectId)
            .IsRequired()
            .HasMaxLength(50)
            .IsUnicode(false);

        builder.HasIndex(x => x.Email)
            .IsUnique()
            .HasDatabaseName("USER_UQ1")
            .HasFilter("\"DeletedAt\" IS NULL");

        builder.HasIndex(x => x.ExternalObjectId)
            .IsUnique()
            .HasDatabaseName("USER_UQ2")
            .HasFilter("\"DeletedAt\" IS NULL");

        builder.Property(x => x.DisplayName)
            .IsRequired()
            .HasMaxLength(200);

        builder.Navigation(x => x.UserCompanyAccesses);

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
