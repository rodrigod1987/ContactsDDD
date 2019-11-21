using Domain.Entities;
using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;
using Domain.Interfaces.Services;

namespace Application
{
  public class ContactAppService : AppServiceBase<Contact>, IContactAppService
  {
    private readonly IContactService service;

    public ContactAppService(IContactService service) : base(service)
    {
      this.service = service;
    }

    public IEnumerable<Contact> GetContactsWithAvatar(Contact contact)
    {
      return service.GetContactsWithAvatar(service.GetAll());
    }
  }
}
