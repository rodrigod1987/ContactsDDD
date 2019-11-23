using Domain.Interfaces.Repositories;
using Domain.Interfaces.UnitOfWork;
using Infrastructure.Repositories;
using Microsoft.Extensions.Configuration;

namespace Services.UnitOfWork
{
  public class UnitOfWork<TEntity> : IUnitOfWork<TEntity> where TEntity : class, IEntity
  {
    private readonly IConfiguration configuration;
    private RepositoryBase<TEntity> _repository;
    public IRepositoryBase<TEntity> Repository
    {
      get
      {
        if (_repository == null)
          _repository = new RepositoryBase<TEntity>(configuration);

        return _repository;
      }
    }

    public UnitOfWork(IConfiguration configuration)
    {
      this.configuration = configuration;
    }

    public int Commit()
    {
      return _repository.DB.SaveChanges();
    }

    public void Dispose()
    {
      _repository.Dispose();
    }
  }
}
