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
    public class RegistrationConfiguration : IEntityTypeConfiguration<Registration>
    {
        public void Configure(EntityTypeBuilder<Registration> builder)
        {
            builder.ToTable(" Registrations");

            builder.Property(r => r.Note);

            builder.Property(r => r.RegisDate).HasDefaultValueSql("GETDATE()").IsRequired();

            builder.HasKey(r => new { r.EventId, r.AttendeeId });

        }
    }
}
