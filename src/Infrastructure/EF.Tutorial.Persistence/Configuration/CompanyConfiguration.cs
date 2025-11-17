using EF.Tutorial.Persistence.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF.Tutorial.Persistence.Configuration;

public class CompanyConfiguration : IEntityTypeConfiguration<Company>
{
    public void Configure(EntityTypeBuilder<Company> builder)
    {
        builder.ToTable("Company");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Code)
            .IsRequired()
            .HasMaxLength(7);

        builder.Property(x => x.LegalName)
            .IsRequired()
            .HasMaxLength(200);

        builder
            .HasIndex(x => x.Code)
            .IsUnique()
            .HasDatabaseName("COMPANY_UQ1")
            .HasFilter("\"DeletedAt\" IS NULL");


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
