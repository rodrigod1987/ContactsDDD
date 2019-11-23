using Domain.Entities;
using Domain.Interfaces.UnitOfWork;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.UnitOfWork
{
  public class PhoneUnitWorker : UnitOfWork<Phone>, IPhoneUnitWorker
  {
    public PhoneUnitWorker(IConfiguration configuration) : base(configuration)
    {
    }
  }
}
