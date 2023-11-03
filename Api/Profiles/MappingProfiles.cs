

using Api.Dtos;
using Core.Entities;
using AutoMapper;

namespace API.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {

        CreateMap<Team,TeamDto>().ReverseMap();
        CreateMap<Driver, DriverDto>().ReverseMap();
        

    }
}