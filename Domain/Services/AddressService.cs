using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using Domain.Interfaces.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Services
{
  public class AddressService : ServiceBase<Address>, IAddressService
  {
    private readonly IAddressUnitWorker unitWorker;

    public AddressService(IAddressUnitWorker unitWorker) 
      : base(unitWorker)
    {
      this.unitWorker = unitWorker;
    }
  }
}
