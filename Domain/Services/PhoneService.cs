using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Services
{
  public class PhoneService : ServiceBase<Phone>, IPhoneService
  {
    private readonly IPhoneRepository repository;

    public PhoneService(IPhoneRepository repository) 
      : base(repository)
    {
      this.repository = repository;
    }
  }
}
