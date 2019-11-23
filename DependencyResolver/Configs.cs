using Application;
using Application.Interfaces;
using Data.UnitOfWork;
using Domain.Interfaces.Services;
using Domain.Interfaces.UnitOfWork;
using Domain.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DependencyResolver
{
  public class Configs
  {
    public static void RegisterComponents(IServiceCollection services)
    {
      services.AddTransient<IContactAppService, ContactAppService>();
      services.AddTransient<IAddressAppService, AddressAppService>();
      services.AddTransient<IEmailAppService, EmailAppService>();
      services.AddTransient<IPhoneAppService, PhoneAppService>();

      services.AddTransient<IContactService, ContactService>();
      services.AddTransient<IAddressService, AddressService>();
      services.AddTransient<IEmailService, EmailService>();
      services.AddTransient<IPhoneService, PhoneService>();

      services.AddTransient<IContactUnitWorker, ContactUnitWorker>();
      services.AddTransient<IAddressUnitWorker, AddressUnitWorker>();
      services.AddTransient<IEmailUnitWorker, EmailUnitWorker>();
      services.AddTransient<IPhoneUnitWorker, PhoneUnitWorker>();
    }
  }
}
