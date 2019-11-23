using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using Domain.Interfaces.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Services
{
  public class EmailService : ServiceBase<Email>, IEmailService
  {
    private readonly IEmailUnitWorker unitWorker;

    public EmailService(IEmailUnitWorker unitWorker) 
      : base(unitWorker)
    {
      this.unitWorker = unitWorker;
    }
  }
}
