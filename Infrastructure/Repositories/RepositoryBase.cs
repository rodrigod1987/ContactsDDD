using Domain.Interfaces;
using Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Domain.Interfaces.Repositories;
using Microsoft.Extensions.Configuration;

namespace InfrastructureLayer.Repositories
{
  public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class, IEntity
  {
    protected readonly ContactDBContext contextDB;

    public RepositoryBase(IConfiguration configuration)
    {
      this.contextDB = new ContactDBContext(configuration);
    }

    private void IncludeNavigationProperties(ref IQueryable<TEntity> dbQuery, Expression<Func<TEntity, object>>[] navigationProperties)
    {
      foreach (var navigationProperty in navigationProperties)
        dbQuery = dbQuery.Include(navigationProperty);
    }

    public IList<TEntity> GetAll(params Expression<Func<TEntity, object>>[] navigationProperties)
    {
      IQueryable<TEntity> dbQuery = contextDB.Set<TEntity>();

      IncludeNavigationProperties(ref dbQuery, navigationProperties);

      return dbQuery.ToList();
    }

    public TEntity GetSingle(Expression<Func<TEntity, bool>> where,
      params Expression<Func<TEntity, object>>[] navigationProperties)
    {
      IQueryable<TEntity> dbQuery = contextDB.Set<TEntity>();

      IncludeNavigationProperties(ref dbQuery, navigationProperties);

      var item = dbQuery
        .SingleOrDefault(where);

      return item;
    }

    public IList<TEntity> GetWhere(Expression<Func<TEntity, bool>> where,
      params Expression<Func<TEntity, object>>[] navigationProperties)
    {
      IQueryable<TEntity> dbQuery = contextDB.Set<TEntity>();

      IncludeNavigationProperties(ref dbQuery, navigationProperties);

      return dbQuery
        .Where(where)
        .ToList();
    }

    public int Remove(TEntity entity)
    {
      contextDB.Set<TEntity>().Remove(entity);
      return contextDB.SaveChanges();
    }

    public TEntity Save(TEntity entity)
    {
      if (entity.Id == 0)
        contextDB.Set<TEntity>().Add(entity);
      else
        contextDB.Set<TEntity>().Update(entity);

      var result = contextDB.SaveChanges();
      return entity;
    }

    public void Dispose()
    {
      throw new NotImplementedException();
    }
  }
}
