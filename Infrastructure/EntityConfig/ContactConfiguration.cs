using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.EntityConfig
{
  public class ContactConfiguration : IEntityTypeConfiguration<Contact>
  {
    public void Configure(EntityTypeBuilder<Contact> builder)
    {
      builder.HasKey(c => c.Id);
      builder.Property(c => c.Name)
        .IsRequired()
        .HasMaxLength(150);
      builder.Property(c => c.Surname)
        .IsRequired()
        .HasMaxLength(150);

      builder.HasKey(c => c.Id);
      builder.HasOne(c => c.Address)
        .WithOne(a => a.Contact);
      builder.HasOne(c => c.Email)
        .WithOne(a => a.Contact);
      builder.HasMany(c => c.Phones)
        .WithOne(a => a.Contact);
    }
  }
}
