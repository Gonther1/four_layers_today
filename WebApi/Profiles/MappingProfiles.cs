using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Dominio.Entities;
using WebApi.Dtos;

namespace WebApi.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<City, CityDto>().ReverseMap();  
        CreateMap<Country, CountryDto>().ReverseMap();  
        CreateMap<Customer, CustomerDto>().ReverseMap();  
        CreateMap<PersonType, PersonTypeDto>().ReverseMap();  
        CreateMap<State, StateDto>().ReverseMap();
        CreateMap<Country, CountryAndStatesDto>().ReverseMap();  
    }
}
