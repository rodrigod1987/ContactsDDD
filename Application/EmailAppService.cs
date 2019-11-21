using Domain.Entities;
using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;
using Domain.Interfaces.Services;

namespace Application
{
  public class EmailAppService : AppServiceBase<Email>, IEmailAppService
  {
    private readonly IEmailService service;

    public EmailAppService(IEmailService service) : base(service)
    {
      this.service = service;
    }
  }
}
