using api.Domain.Models;
using AutoMapper;
using GoogleApi.Entities.Places.Search.NearBy.Request;

namespace api.api.Services.Profiles
{
    public class PlacesNearBySearchRequestProfile : Profile
    {
        public PlacesNearBySearchRequestProfile()
        {
            CreateMap<PlaceSearchParameters, PlacesNearBySearchRequest>()
                .ForMember(searchRequest => searchRequest.Location,
                    map =>
                        map.MapFrom(searchParams => searchParams.SearchLocation))
                .ForMember(searchRequest => searchRequest.Radius,
                    map =>
                        map.MapFrom(searchParams => searchParams.SearchRadiusMeters));
        }
    }
}