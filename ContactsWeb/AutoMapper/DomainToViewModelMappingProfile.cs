using AutoMapper;
using ContactsWeb.ViewModels;
using Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ContactsWeb.AutoMapper
{
  public class DomainToViewModelMappingProfile : IDomainToViewModelMappingProfile
  {
    private readonly IServiceCollection services;

    public DomainToViewModelMappingProfile(IServiceCollection services)
    {
      this.services = services;
    }

    public void RegisterMap()
    {
      var config = new MapperConfiguration(config =>
      {
        config.CreateMap<Contact, ContactViewModel>();
        config.CreateMap<Address, AddressViewModel>();
        config.CreateMap<Email, EmailViewModel>();
        config.CreateMap<Phone, PhoneViewModel>();
      });

      IMapper mapper = config.CreateMapper();
      services.AddSingleton(mapper);
    }
  }
}
