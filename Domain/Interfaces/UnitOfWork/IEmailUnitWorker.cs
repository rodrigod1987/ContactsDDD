using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces.UnitOfWork
{
  public interface IEmailUnitWorker : IUnitOfWork<Email>
  {
  }
}
