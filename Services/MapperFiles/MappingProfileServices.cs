using AutoMapper;
using Challenge.Repositories.Models;
using Challenge.Services.DTOs;

namespace Challenge.Services.MapperFiles
{
    public class MappingProfileServices : Profile
    {
        public MappingProfileServices()
        {
            CreateMap<Location, LocationDto>();
            CreateMap<Inmueble, InmuebleDto>();
            CreateMap<LocationDto, Location>();
            CreateMap<InmuebleDto, Inmueble>();
        }
    }
}