using Application.Interfaces;
using AutoMapper;
using ContactsWeb.ViewModels;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
      return contactAppService.GetAll();
    }

    [HttpGet("{id}")]
    public Contact GetSingle(int id)
    {
      return contactAppService.GetSingle(contact => contact.Id == id,
        contact => contact.Address,
        contact => contact.Email,
        contact => contact.Phones);
    }

    [HttpGet]
    [Route("GetContactsWithAvatar")]
    public IEnumerable<Contact> GetContactsWithAvatar()
    {
      return contactAppService.GetContactsWithAvatar();
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
