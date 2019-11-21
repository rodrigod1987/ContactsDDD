using Domain.Entities;
using System.Collections.Generic;

namespace Application.Interfaces
{
  public interface IContactAppService : IAppServiceBase<Contact>
  {
    IEnumerable<Contact> GetContactsWithAvatar(Contact contact);
  }
}
