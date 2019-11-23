using Domain.Entities;
using Domain.Interfaces.Repositories;
using Data.Context;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Repositories
{
  public class EmailRepository : RepositoryBase<Email>, IEmailRepository
  {
    public EmailRepository(IConfiguration configuration) : base(configuration)
    {
    }
  }
}
