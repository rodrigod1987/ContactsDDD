using Core;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;

namespace Services
{
  public class PhoneService : ServiceBase<Phone>, IPhoneService
  {
    private readonly IUnitOfWork unitWorker;
    private readonly IPhoneRepository repository;

    public PhoneService(IUnitOfWork unitWorker, IPhoneRepository repository) 
      : base(unitWorker, repository)
    {
      this.unitWorker = unitWorker;
      this.repository = repository;
    }
  }
}
