using Domain.Interfaces.Repositories;
using Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Data.Model
{
  public class DataService : IDataService
  {
    private readonly DatabaseContext contextDB;

    public DataService(DatabaseContext contextDB)
    {
      this.contextDB = contextDB;
    }

    public void InicializaDB()
    {
      contextDB
        .Database
        .Migrate();
    }
  }
}
