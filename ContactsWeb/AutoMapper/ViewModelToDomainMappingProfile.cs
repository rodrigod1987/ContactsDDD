using AutoMapper;
using ContactsWeb.ViewModels;
using Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactsWeb.AutoMapper
{
  public class ViewModelToDomainMappingProfile : IViewModelToDomainMappingProfile
  {
    private readonly IServiceCollection services;

    public ViewModelToDomainMappingProfile(IServiceCollection services)
    {
      this.services = services;
    }

    public void RegisterMap()
    {
      var config = new MapperConfiguration(config =>
      {
        config.CreateMap<ContactViewModel, Contact>();
        config.CreateMap<AddressViewModel, Address>();
        config.CreateMap<EmailViewModel, Email>();
        config.CreateMap<PhoneViewModel, Phone>();
      });

      IMapper mapper = config.CreateMapper();
      services.AddSingleton(mapper);
    }

  }
}
