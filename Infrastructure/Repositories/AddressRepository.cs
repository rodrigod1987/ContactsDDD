using Domain.Entities;
using Domain.Interfaces.Repositories;
using Data.Context;
using Microsoft.Extensions.Configuration;

namespace InfrastructureLayer.Repositories
{

  public class AddressRepository : RepositoryBase<Address>, IAddressRepository
  {
    public AddressRepository(IConfiguration configuration) : base(configuration)
    {
    }
  }
}
