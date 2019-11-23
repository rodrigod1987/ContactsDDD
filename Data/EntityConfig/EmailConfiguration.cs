using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.EntityConfig
{
  public class EmailConfiguration : IEntityTypeConfiguration<Email>
  {
    public void Configure(EntityTypeBuilder<Email> builder)
    {
      builder.HasKey(entity => entity.Id);
      builder.Property(e => e.Mail)
        .IsRequired()
        .HasMaxLength(255);

      builder.HasOne(entity => entity.Contact)
        .WithOne(entity => entity.Email)
        .HasForeignKey<Email>(entity => entity.ContactId);
    }
  }
}
