using Data.Context;
using Domain.Entities;
using Domain.Interfaces.Repositories;

namespace Data.Repositories
{

  public class AddressRepository : RepositoryBase<Address>, IAddressRepository
  {
    public AddressRepository(DatabaseContext databaseContext) : base(databaseContext)
    {
    }
  }
}
