using Microsoft.Extensions.DependencyInjection;

namespace ContactsWeb.AutoMapper
{
  public class Configs
  {
    public static void RegisterMappings(IServiceCollection services)
    {
      services.AddTransient<IMappingProfile, DomainToViewModelMappingProfile>();
      services.AddTransient<IMappingProfile, ViewModelToDomainMappingProfile>();
    }
  }
}
