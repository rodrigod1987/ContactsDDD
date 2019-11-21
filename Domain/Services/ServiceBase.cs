using Domain.Interfaces;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Domain.Services
{
  public class ServiceBase<TEntity> : IServiceBase<TEntity> 
    where TEntity : class, IEntity
  {
    private readonly IRepositoryBase<TEntity> repository;

    public ServiceBase(IRepositoryBase<TEntity> repository)
    {
      this.repository = repository;
    }

    public IList<TEntity> GetAll(params Expression<Func<TEntity, object>>[] navigationProperties)
    {
      return repository.GetAll(navigationProperties);
    }

    public TEntity GetSingle(Expression<Func<TEntity, bool>> where, params Expression<Func<TEntity, object>>[] navigationProperties)
    {
      return repository.GetSingle(where, navigationProperties);
    }

    public IList<TEntity> GetWhere(Expression<Func<TEntity, bool>> where, params Expression<Func<TEntity, object>>[] navigationProperties)
    {
      return GetWhere(where, navigationProperties);
    }

    public int Remove(TEntity entity)
    {
      return repository.Remove(entity);
    }

    public TEntity Save(TEntity entity)
    {
      return repository.Save(entity);
    }

    public void Dispose()
    {
      repository.Dispose();
    }
  }
}
