using Domain.Entities;
using Domain.Interfaces.Repositories;
using Data.Context;

namespace Data.Repositories
{
  public class EmailRepository : RepositoryBase<Email>, IEmailRepository
  {
    public EmailRepository(DatabaseContext databaseContext) : base(databaseContext)
    {
    }
  }
}
