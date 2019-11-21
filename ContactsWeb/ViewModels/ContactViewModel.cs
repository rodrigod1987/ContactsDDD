using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactsWeb.ViewModels
{
  public class ContactViewModel
  {
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Middlename { get; set; }
    public byte[] Avatar { get; set; }
    public AddressViewModel Address { get; set; }
    public EmailViewModel Email { get; set; }
    public IList<PhoneViewModel> Phones { get; set; }
  }
}
