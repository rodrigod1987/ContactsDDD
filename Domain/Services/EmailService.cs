using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Services
{
  public class EmailService : ServiceBase<Email>, IEmailService
  {
    private readonly IEmailRepository repository;

    public EmailService(IEmailRepository repository) 
      : base(repository)
    {
      this.repository = repository;
    }
  }
}
