using EventHub.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EventHub.Configurations
{
    public class EventConfiguration : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.ToTable("Events");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Title).IsRequired();

            builder.Property(e => e.Description).IsRequired();

            builder.Property(e => e.StartDate).IsRequired();

            builder.Property(e => e.EndDate);

            builder.Property(e => e.AttendeesNum).IsRequired();

            builder.Property(e => e.CreatedDate).IsRequired().HasDefaultValueSql("GETDATE()");

            builder.Property(e => e.ModifiedDate).IsRequired().HasDefaultValueSql("GETDATE()");

           builder.HasOne(e => e.ParentEvent)
                  .WithMany(e => e.Sessions)
                  .HasForeignKey(e => e.ParentEventId)
                  .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
