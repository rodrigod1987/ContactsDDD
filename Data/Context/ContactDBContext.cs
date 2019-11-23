using Data.EntityConfig;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Data.Context
{
  public class ContactDBContext : DbContext
  {
    private readonly IConfiguration configuration;

    public ContactDBContext(IConfiguration configuration)
    {
      this.configuration = configuration;
    }
    
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<Email> Emails { get; set; }
    public DbSet<Phone> Phones { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer(configuration.GetConnectionString("ContactsDB"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.ApplyConfiguration(new ContactConfiguration());
      modelBuilder.ApplyConfiguration(new AddressConfiguration());
      modelBuilder.ApplyConfiguration(new EmailConfiguration());
      modelBuilder.ApplyConfiguration(new PhoneConfiguration());
    }
  }
}
