using EventHub.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventHub.Configurations
{
    public class OrganizerProfileConfiguration : IEntityTypeConfiguration<OrganizerProfile>
    {
        public void Configure(EntityTypeBuilder<OrganizerProfile> builder)
        {
            builder.ToTable("OrganizerProfiles");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Bio).HasMaxLength(1000);
            builder.Property(p => p.WebsiteUrl).HasMaxLength(300);
            builder.Property(p => p.LogoUrl).HasMaxLength(300);
        }
    }
}
