using EventHub.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            builder.Property(b => b.Badgedate).IsRequired();

            builder.Property(b => b.Tier).IsRequired();

            builder.HasOne(b => b.Attendees).WithOne(a => a.Badge)
                   .HasForeignKey<Badge>(b => b.AttendeesId)
                   .OnDelete(DeleteBehavior.Cascade)
                   .IsRequired();
        }
    }
}
