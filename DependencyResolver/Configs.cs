using Application;
using Application.Interfaces;
using Core;
using Data.Context;
using Data.UnitOfWork;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Services;
using Data.Model;

namespace DependencyResolver
{
  public class Configs
  {
    public static void RegisterComponents(IServiceCollection services)
    {
      services.AddDbContext<DatabaseContext>();

      services.AddTransient<IDataService, DataService>();

      services.AddTransient<IContactAppService, ContactAppService>();
      services.AddTransient<IAddressAppService, AddressAppService>();
      services.AddTransient<IEmailAppService, EmailAppService>();
      services.AddTransient<IPhoneAppService, PhoneAppService>();

      services.AddTransient<IContactService, ContactService>();
      services.AddTransient<IAddressService, AddressService>();
      services.AddTransient<IEmailService, EmailService>();
      services.AddTransient<IPhoneService, PhoneService>();

      services.AddTransient<IContactRepository, ContactRepository>();
      services.AddTransient<IAddressRepository, AddressRepository>();
      services.AddTransient<IEmailRepository, EmailRepository>();
      services.AddTransient<IPhoneRepository, PhoneRepository>();

      services.AddTransient<IUnitOfWork, UnitOfWork>();
    }
  }
}
