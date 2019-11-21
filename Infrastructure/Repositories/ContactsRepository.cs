using Domain.Entities;
using Domain.Interfaces.Repositories;
using Data.Context;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;

namespace InfrastructureLayer.Repositories
{
  public class ContactRepository : RepositoryBase<Contact>, IContactRepository
  {
    private readonly IAddressRepository addressRepository;
    private readonly IEmailRepository emailRepository;
    private readonly IPhoneRepository phoneRepository;

    public ContactRepository(IConfiguration configuration,
      IAddressRepository addressRepository,
      IEmailRepository emailRepository, 
      IPhoneRepository phoneRepository) : base(configuration)
    {
      this.addressRepository = addressRepository;
      this.emailRepository = emailRepository;
      this.phoneRepository = phoneRepository;
    }

    public Address SaveAddress(Address address)
    {
      return addressRepository.Save(address);
    }

    public IList<Phone> SavePhones(IList<Phone> phones)
    {
      IList<Phone> phonesDb = new List<Phone>();

      foreach (var phone in phones)
        phonesDb.Add(phoneRepository.Save(phone));

      return phonesDb;
    }

    public Email SaveEmail(Email email)
    {
      return emailRepository.Save(email);
    }
  }
}
