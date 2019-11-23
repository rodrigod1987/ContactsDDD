using Application.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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
    public int Save(Contact contact)
    {
      return contactAppService.Save(contact);
    }

    [HttpDelete]
    public void Delete(Contact contact)
    {
      contactAppService.Remove(contact);
    }
  }
}
