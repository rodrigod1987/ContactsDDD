using Data.Context;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Microsoft.Extensions.Configuration;

namespace Data.Repositories
{

  public class PhoneRepository : RepositoryBase<Phone>, IPhoneRepository
  {
    public PhoneRepository(DatabaseContext databaseContext) : base(databaseContext)
    {
    }
  }
}
