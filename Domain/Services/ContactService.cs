using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Services
{
  public class ContactService : ServiceBase<Contact>, IContactService
  {
    private readonly IContactRepository repository;

    public ContactService(IContactRepository repository) 
      : base(repository)
    {
      this.repository = repository;
    }

    public IEnumerable<Contact> GetContactsWithAvatar(IEnumerable<Contact> contacts)
    {
      return contacts.Where(c => c.HasAvatar(c));
    }
  }
}
