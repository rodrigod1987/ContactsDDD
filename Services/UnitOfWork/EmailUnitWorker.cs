using Domain.Entities;
using Domain.Interfaces.UnitOfWork;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.UnitOfWork
{
  public class EmailUnitWorker : UnitOfWork<Email>, IEmailUnitWorker
  {
    public EmailUnitWorker(IConfiguration configuration) : base(configuration)
    {
    }
  }
}
