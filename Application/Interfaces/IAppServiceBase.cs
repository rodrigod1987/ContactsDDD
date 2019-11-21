using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Application.Interfaces
{
  public interface IAppServiceBase<TEntity> where TEntity : class
  {
    IList<TEntity> GetAll(params Expression<Func<TEntity, object>>[] navigationProperties);
    TEntity GetSingle(Expression<Func<TEntity, bool>> where, params Expression<Func<TEntity, object>>[] navigationProperties);
    IList<TEntity> GetWhere(Expression<Func<TEntity, bool>> where, params Expression<Func<TEntity, object>>[] navigationProperties);
    int Remove(TEntity entity);
    TEntity Save(TEntity entity);
  }
}
