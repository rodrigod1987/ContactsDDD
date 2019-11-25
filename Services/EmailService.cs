using Core;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;

namespace Services
{
  public class EmailService : ServiceBase<Email>, IEmailService
  {
    private readonly IUnitOfWork unitWorker;
    private readonly IEmailRepository repository;

    public EmailService(IUnitOfWork unitWorker, IEmailRepository repository) 
      : base(unitWorker, repository)
    {
      this.unitWorker = unitWorker;
      this.repository = repository;
    }
  }
}
