using System.Collections.Generic;

namespace Domain.Entities
{
  public class Contact : Entity
  {
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Middlename { get; set; }
    public byte[] Avatar { get; set; }
    public Address Address { get; set; }
    public Email Email { get; set; }
    public IList<Phone> Phones { get; set; }

    public bool HasAvatar(Contact contact)
    {
      return contact.Avatar.Length > 0;
    }
  }
}
