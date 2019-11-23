using Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces.UnitOfWork
{
  public interface IUnitOfWork<TEntity> : IDisposable where TEntity : class, IEntity
  {
    IRepositoryBase<TEntity> Repository { get; }
    int Commit();
  }
}
