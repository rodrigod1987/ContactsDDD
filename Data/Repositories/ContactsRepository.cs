using Domain.Entities;
using Domain.Interfaces.Repositories;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Data.Context;

namespace Data.Repositories
{
  public class ContactRepository : RepositoryBase<Contact>, IContactRepository
  {
    public ContactRepository(DatabaseContext databaseContext) : base(databaseContext)
    {
    }
  }
}
