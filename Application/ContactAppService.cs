using Domain.Entities;
using Application.Interfaces;
using System;
using System.Collections.Generic;
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

    public IEnumerable<Contact> GetContactsWithAvatar()
    {
      return service.GetContactsWithAvatar(service.GetAll());
    }

    public int Save(Contact contact)
    {
      try
      {
        if (contact.Address != null)
          contact.Address.Contact = contact;

        if (contact.Email != null)
          contact.Email.Contact = contact;

        if (contact.Phones != null)
        {
          foreach (var phone in contact.Phones)
            phone.Contact = contact;
        }

        int affectedRows = SaveContact(contact);

        return affectedRows;
      }
      catch (Exception ex)
      {
        throw new Exception("Ocorreu um erro na aplicação e a transação foi cancelada.", 
          ex.InnerException);
      }

    }

    private int SaveContact(Contact contact)
    {
      int affectedRows;
      if (contact.Id == 0)
        affectedRows = service.Add(contact);
      else
        affectedRows = service.Update(contact);
      return affectedRows;
    }
  }
}
