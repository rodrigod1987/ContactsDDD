using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using Domain.Interfaces.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Domain.Services
{
  public class ServiceBase<TEntity> : IServiceBase<TEntity> 
    where TEntity : class, IEntity
  {
    private readonly IUnitOfWork<TEntity> unitWorker;

    public ServiceBase(IUnitOfWork<TEntity> repository)
    {
      this.unitWorker = repository;
    }

    public IList<TEntity> GetAll(params Expression<Func<TEntity, object>>[] navigationProperties)
    {
      return unitWorker.Repository.GetAll(navigationProperties);
    }

    public TEntity GetSingle(Expression<Func<TEntity, bool>> where, params Expression<Func<TEntity, object>>[] navigationProperties)
    {
      return unitWorker.Repository.GetSingle(where, navigationProperties);
    }

    public IList<TEntity> GetWhere(Expression<Func<TEntity, bool>> where, params Expression<Func<TEntity, object>>[] navigationProperties)
    {
      return GetWhere(where, navigationProperties);
    }

    public int Remove(TEntity entity)
    {
      unitWorker.Repository.Remove(entity);
      return unitWorker.Commit();
    }

    public int Add(TEntity entity)
    {
      unitWorker.Repository.Add(entity);
      return unitWorker.Commit();
    }

    public int Update(TEntity entity)
    {
      unitWorker.Repository.Update(entity);
      return unitWorker.Commit();
    }

    public void Dispose()
    {
      unitWorker.Dispose();
    }
  }
}
