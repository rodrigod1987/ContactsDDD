using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Domain.Interfaces.Services
{
  public interface IServiceBase<TEntity> where TEntity : class
  {
    IList<TEntity> GetAll(params Expression<Func<TEntity, object>>[] navigationProperties);
    TEntity GetSingle(Expression<Func<TEntity, bool>> where, params Expression<Func<TEntity, object>>[] navigationProperties);
    IList<TEntity> GetWhere(Expression<Func<TEntity, bool>> where, params Expression<Func<TEntity, object>>[] navigationProperties);
    int Remove(TEntity entity);
    int Add(TEntity entity);
    int Update(TEntity entity);
  }
}
