using Domain.Entities;
using Domain.Interfaces.Repositories;
using Data.Context;
using Microsoft.Extensions.Configuration;

namespace InfrastructureLayer.Repositories
{

  public class PhoneRepository : RepositoryBase<Phone>, IPhoneRepository
  {
    public PhoneRepository(IConfiguration configuration) : base(configuration)
    {
    }
  }
}
