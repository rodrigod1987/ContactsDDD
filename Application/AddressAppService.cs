using Domain.Entities;
using Application.Interfaces;
using Domain.Interfaces.Services;

namespace Application
{
  public class AddressAppService : AppServiceBase<Address>, IAddressAppService
  {
    private readonly IAddressService service;

    public AddressAppService(IAddressService service) : base(service)
    {
      this.service = service;
    }
  }
}
