using Application;
using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ContactsWeb.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class ContactController : ControllerBase
  {
    private readonly IContactAppService contactAppService;

    public ContactController(IContactAppService contactAppService)
    {
      this.contactAppService = contactAppService;
    }

    [HttpGet]
    public IList<Contact> GetAll()
    {
      return contactAppService.GetAll(contact => contact.Address,
        contact => contact.Email);
    }

    [HttpGet("{id}")]
    public Contact GetSingle(int id)
    {
      return contactAppService.GetSingle(contact => contact.Id == id, 
        contact => contact.Address,
        contact => contact.Email,
        contact => contact.Phones);
    }

    [HttpPost]
    public JsonResult Save(Contact contact)
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

        contactAppService.Save(contact);
      }
      catch (Exception ex)
      {
        var result = new
        {
          error = "Ocorreu um erro na aplicação e a transação foi cancelada.",
          innerException = ex.InnerException,
          exception = ex,
          exceptionMessage = ex.Message
        };

        return new JsonResult(result);
      }

      return new JsonResult(new
      {
        message = "Transação realizada com sucesso.",
      });
    }

    [HttpDelete]
    public void Delete(Contact contact)
    {
      contactAppService.Remove(contact);
    }

  }
}
