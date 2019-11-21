using Domain.Entities;
using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;
using Domain.Interfaces.Services;

namespace Application
{
  public class PhoneAppService : AppServiceBase<Phone>, IPhoneAppService
  {
    private readonly IPhoneService service;

    public PhoneAppService(IPhoneService service) : base(service)
    {
      this.service = service;
    }
  }
}
