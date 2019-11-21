using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.EntityConfig
{
  public class PhoneConfiguration : IEntityTypeConfiguration<Phone>
  {
    public void Configure(EntityTypeBuilder<Phone> builder)
    {
      builder.HasKey(entity => entity.Id);
      builder.Property(p => p.Number).IsRequired();

      builder.HasOne(entity => entity.Contact)
        .WithMany(entity => entity.Phones)
        .HasForeignKey(entity => entity.ContactId);
    }
  }
}
