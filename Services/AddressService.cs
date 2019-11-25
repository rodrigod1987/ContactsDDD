using Core;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;

namespace Services
{
  public class AddressService : ServiceBase<Address>, IAddressService
  {
    private readonly IUnitOfWork unitWorker;
    private readonly IAddressRepository repository;

    public AddressService(IUnitOfWork unitWorker, IAddressRepository repository) 
      : base(unitWorker, repository)
    {
      this.unitWorker = unitWorker;
      this.repository = repository;
    }
  }
}
