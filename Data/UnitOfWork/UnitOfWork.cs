using Core;
using Data.Context;
using System;

namespace Data.UnitOfWork
{
  public class UnitOfWork : IUnitOfWork
  {
    private readonly DatabaseContext databaseContext;
    private bool disposed = false;

    public UnitOfWork(DatabaseContext databaseContext)
    {
      this.databaseContext = databaseContext;
    }

    public int Commit()
    {
      if (disposed)
        throw new ObjectDisposedException(this.GetType().FullName);

      return databaseContext.SaveChanges();
    }

    public void Dispose()
    {
      Dispose(true);
      GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
      if (disposed) return;

      if (disposing && databaseContext != null)
      {
        databaseContext.Dispose();
      }

      disposed = true;
    }
  }
}
