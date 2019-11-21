using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.EntityConfig
{
  public class AddressConfiguration : IEntityTypeConfiguration<Address>
  {
    public void Configure(EntityTypeBuilder<Address> builder)
    {
      builder.HasKey(entity => entity.Id);
      builder.Property(a => a.Street)
        .IsRequired()
        .HasMaxLength(150);

      builder.HasOne(entity => entity.Contact)
        .WithOne(entity => entity.Address)
        .HasForeignKey<Address>(entity => entity.ContactId);
    }
  }
}
