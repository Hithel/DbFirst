

using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
    public class DriverConfiguration : IEntityTypeConfiguration<Driver>
        {
            public void Configure(EntityTypeBuilder<Driver> builder)
            {
                builder.HasKey(e => e.Id).HasName("PRIMARY");

                builder.ToTable("driver");

                builder.Property(e => e.Age).HasColumnName("age");
                builder.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");
            }
        }