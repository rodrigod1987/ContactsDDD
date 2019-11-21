using Domain.Entities;
using System.Collections.Generic;

namespace Domain.Interfaces.Repositories
{
  public interface IContactRepository : IRepositoryBase<Contact> 
  {
    /// <summary>
    /// Atualiza ou inclui um endereço
    /// </summary>
    /// <param name="address"></param>
    /// <returns></returns>
    Address SaveAddress(Address address);
    /// <summary>
    /// Atualiza ou inclui um telefone
    /// </summary>
    /// <param name="phones"></param>
    /// <returns></returns>
    IList<Phone> SavePhones(IList<Phone> phones);
    /// <summary>
    /// Atualiza ou inclui um email
    /// </summary>
    /// <param name="email"></param>
    /// <returns></returns>
    Email SaveEmail(Email email);
  }
}
