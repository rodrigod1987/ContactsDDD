using Core;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
  public class ContactService : ServiceBase<Contact>, IContactService
  {
    private readonly IUnitOfWork unitWorker;
    private readonly IContactRepository repository;

    public ContactService(IUnitOfWork unitWorker, IContactRepository repository) 
      : base(unitWorker, repository)
    {
      this.unitWorker = unitWorker;
      this.repository = repository;
    }

    public IEnumerable<Contact> GetContactsWithAvatar(IEnumerable<Contact> contacts)
    {
      return contacts.Where(c => c.HasAvatar(c));
    }
  }
}
