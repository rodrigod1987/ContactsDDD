using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using Domain.Interfaces.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Services
{
  public class PhoneService : ServiceBase<Phone>, IPhoneService
  {
    private readonly IPhoneUnitWorker unitWorker;

    public PhoneService(IPhoneUnitWorker unitWorker) 
      : base(unitWorker)
    {
      this.unitWorker = unitWorker;
    }
  }
}
