using Domain.Entities;
using Domain.Interfaces.Repositories;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Repositories
{

  public class AddressRepository : RepositoryBase<Address>, IAddressRepository
  {
    public AddressRepository(IConfiguration configuration) : base(configuration)
    {
    }
  }
}
