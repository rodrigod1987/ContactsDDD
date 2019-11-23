using Domain.Interfaces.Repositories;
using Data.Context;
using Microsoft.EntityFrameworkCore;

namespace InfrastructureLayer.Model
{
  public class DataService : IDataService
  {
    private readonly ContactDBContext contextDB;

    public DataService(ContactDBContext contextDB)
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
