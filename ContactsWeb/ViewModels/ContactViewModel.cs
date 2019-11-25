using System.Collections.Generic;

namespace ContactsWeb.ViewModels
{
  public class ContactViewModel
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Middlename { get; set; }
    public byte[] Avatar { get; set; }
    public AddressViewModel Address { get; set; }
    public EmailViewModel Email { get; set; }
    public IList<PhoneViewModel> Phones { get; set; }
  }
}
