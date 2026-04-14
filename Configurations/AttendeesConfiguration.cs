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
    public class AttendeesConfiguration : IEntityTypeConfiguration<Attendee>
    {
        public void Configure(EntityTypeBuilder<Attendee> builder)
        {
            builder.ToTable("Attendees");

            builder.HasKey(a => a.Id);

            builder.Property(a => a.FullName).IsRequired();

            builder.Property(a => a.Email).IsRequired();

            builder.OwnsOne(a => a.Address, Address =>
            {
                Address.Property(a => a.Street).IsRequired();
                Address.Property(a => a.City).IsRequired();
                Address.Property(a => a.Country).IsRequired();
                Address.Property(a => a.PostalCode).IsRequired();

            });

        }
    }
}
