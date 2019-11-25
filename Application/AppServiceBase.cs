using Application.Interfaces;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Application
{
  public class AppServiceBase<TEntity> : IAppServiceBase<TEntity> where TEntity : class, IEntity
  {
    private readonly IServiceBase<TEntity> service;

    public AppServiceBase(IServiceBase<TEntity> service)
    {
      this.service = service;
    }

    public IList<TEntity> GetAll(params Expression<Func<TEntity, object>>[] navigationProperties)
    {
      return service.GetAll(navigationProperties);
    }

    public TEntity GetSingle(Expression<Func<TEntity, bool>> where, params Expression<Func<TEntity, object>>[] navigationProperties)
    {
      return service.GetSingle(where, navigationProperties);
    }

    public IList<TEntity> GetWhere(Expression<Func<TEntity, bool>> where, params Expression<Func<TEntity, object>>[] navigationProperties)
    {
      return service.GetWhere(where, navigationProperties);
    }

    public int Remove(TEntity entity)
    {
      return service.Remove(entity);
    }

    public int Add(TEntity entity)
    {
      return service.Add(entity);
    }

    public int Update(TEntity entity)
    {
      return service.Update(entity);
    }
  }
}
