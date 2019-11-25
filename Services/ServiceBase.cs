using Core;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Services
{
  public class ServiceBase<TEntity> : IServiceBase<TEntity> 
    where TEntity : class, IEntity
  {
    private readonly IUnitOfWork unitWorker;
    private readonly IRepositoryBase<TEntity> repository;

    public ServiceBase(IUnitOfWork unitWorker,
      IRepositoryBase<TEntity> repository)
    {
      this.unitWorker = unitWorker;
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
      repository.Remove(entity);
      return unitWorker.Commit();
    }

    public int Add(TEntity entity)
    {
      using (unitWorker)
      {
        repository.Add(entity);
        return unitWorker.Commit();
      }
    }

    public int Update(TEntity entity)
    {
      using (unitWorker)
      {
        repository.Update(entity);
        return unitWorker.Commit();
      }
    }
  }
}
