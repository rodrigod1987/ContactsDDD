using Domain.Entities;
using Domain.Interfaces.Repositories;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Repositories
{

  public class PhoneRepository : RepositoryBase<Phone>, IPhoneRepository
  {
    public PhoneRepository(IConfiguration configuration) : base(configuration)
    {
    }
  }
}
