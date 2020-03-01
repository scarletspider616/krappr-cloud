using api.Domain.Models;
using AutoMapper;
using GoogleApi.Entities.Places.Search.NearBy.Response;

namespace api.api.Services.Profiles
{
    public class BathroomProfile : Profile
    {
        public BathroomProfile()
        {
            CreateMap<NearByResult, Bathroom>()
                .ForMember(bathroom => bathroom.Name,
                    map =>
                        map.MapFrom(nearbyResult => nearbyResult.Name))
                .ForMember(bathroom => bathroom.Location,
                    map =>
                        map.MapFrom(nearbyResult => nearbyResult.Geometry.Location));
        }
    }
}