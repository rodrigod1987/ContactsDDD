using Domain.Entities;
using Domain.Interfaces.UnitOfWork;
using Microsoft.Extensions.Configuration;

namespace Data.UnitOfWork
{
  public class ContactUnitWorker : UnitOfWork<Contact>, IContactUnitWorker
  {
    public ContactUnitWorker(IConfiguration configuration)
      : base(configuration)
    {
    }
  }
}
