using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using Domain.Interfaces.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Services
{
  public class ContactService : ServiceBase<Contact>, IContactService
  {
    private readonly IContactUnitWorker unitWorker;
    private readonly IAddressUnitWorker addressUnitWorker;
    private readonly IEmailUnitWorker emailUnitWorker;
    private readonly IPhoneUnitWorker phoneUnitWorker;


    public ContactService(IContactUnitWorker unitWorker,
      IAddressUnitWorker addressUnitWorker,
      IEmailUnitWorker emailUnitWorker,
      IPhoneUnitWorker phoneUnitWorker) 
      : base(unitWorker)
    {
      this.unitWorker = unitWorker;
      this.addressUnitWorker = addressUnitWorker;
      this.emailUnitWorker = emailUnitWorker;
      this.phoneUnitWorker = phoneUnitWorker;
    }

    public IEnumerable<Contact> GetContactsWithAvatar(IEnumerable<Contact> contacts)
    {
      return contacts.Where(c => c.HasAvatar(c));
    }
  }
}
