using Domain.Entities;
using Domain.Interfaces.Repositories;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Repositories
{
  public class ContactRepository : RepositoryBase<Contact>, IContactRepository
  {
    public ContactRepository(IConfiguration configuration) : base(configuration)
    {
    }
  }
}
