using Domain.Entities;
using System.Collections.Generic;

namespace Domain.Interfaces.Services
{
  public interface IContactService : IServiceBase<Contact>
  {
    IEnumerable<Contact> GetContactsWithAvatar(IEnumerable<Contact> contact);
  }
}
