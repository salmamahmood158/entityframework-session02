using EventHub.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventHub.Configurations
{
    public class BadgeConfiguration : IEntityTypeConfiguration<Badge>
    {
        public void Configure(EntityTypeBuilder<Badge> builder)
        {
            builder.ToTable("Badges");
            builder.HasKey(b => b.Id);

            builder.Property(b => b.BadgeNumber).IsRequired();
            builder.HasIndex(b => b.BadgeNumber).IsUnique();

            builder.Property(b => b.IssuedDate)
                   .HasColumnType("date")
                   .IsRequired();

            builder.Property(b => b.Tier)
                   .HasConversion<string>()
                   .HasMaxLength(20)
                   .IsRequired();
        }
    }
}
