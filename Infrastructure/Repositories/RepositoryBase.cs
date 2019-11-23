using Domain.Interfaces;
using Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Domain.Interfaces.Repositories;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Repositories
{
  public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class, IEntity
  {
    public readonly ContactDBContext DB;

    public RepositoryBase(IConfiguration configuration)
    {
      this.DB = new ContactDBContext(configuration);
    }

    private void IncludeNavigationProperties(ref IQueryable<TEntity> dbQuery, Expression<Func<TEntity, object>>[] navigationProperties)
    {
      foreach (var navigationProperty in navigationProperties)
        dbQuery = dbQuery.Include(navigationProperty);
    }

    public IList<TEntity> GetAll(params Expression<Func<TEntity, object>>[] navigationProperties)
    {
      IQueryable<TEntity> dbQuery = DB.Set<TEntity>();

      IncludeNavigationProperties(ref dbQuery, navigationProperties);

      return dbQuery.ToList();
    }

    public TEntity GetSingle(Expression<Func<TEntity, bool>> where,
      params Expression<Func<TEntity, object>>[] navigationProperties)
    {
      IQueryable<TEntity> dbQuery = DB.Set<TEntity>();

      IncludeNavigationProperties(ref dbQuery, navigationProperties);

      var item = dbQuery
        .SingleOrDefault(where);

      return item;
    }

    public IList<TEntity> GetWhere(Expression<Func<TEntity, bool>> where,
      params Expression<Func<TEntity, object>>[] navigationProperties)
    {
      IQueryable<TEntity> dbQuery = DB.Set<TEntity>();

      IncludeNavigationProperties(ref dbQuery, navigationProperties);

      return dbQuery
        .Where(where)
        .ToList();
    }

    public void Remove(TEntity entity)
    {
      DB.Set<TEntity>().Remove(entity);
    }

    public void Add(TEntity entity)
    {
      DB.Set<TEntity>().Add(entity);
    }

    public void Update(TEntity entity)
    {
      DB.Set<TEntity>().Update(entity);
    }

    public void Dispose()
    {
      if (DB != null)
      {
        DB.Dispose();
      }
      GC.SuppressFinalize(this);
    }
  }
}
