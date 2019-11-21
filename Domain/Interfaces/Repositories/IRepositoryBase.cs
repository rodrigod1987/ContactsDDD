using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Domain.Interfaces.Repositories
{
  public interface IRepositoryBase<TEntity>  
    where TEntity : class, IEntity
  {
    IList<TEntity> GetAll(params Expression<Func<TEntity, object>>[] navigationProperties);
    TEntity GetSingle(Expression<Func<TEntity, bool>> where, params Expression<Func<TEntity, object>>[] navigationProperties);
    IList<TEntity> GetWhere(Expression<Func<TEntity, bool>> where, params Expression<Func<TEntity, object>>[] navigationProperties);
    int Remove(TEntity entity);
    TEntity Save(TEntity entity);
    void Dispose();
  }
}