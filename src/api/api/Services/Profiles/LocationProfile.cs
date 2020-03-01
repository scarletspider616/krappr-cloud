using api.Domain.Models;
using AutoMapper;
using GoogleApi.Entities.Places.Search.NearBy.Request;
using Location = api.Domain.Models.Location;


namespace api.api.Services.Profiles
{
    public class LocationProfile : Profile
    {
        public LocationProfile()
        {
            CreateMap<Location, GoogleApi.Entities.Places.Search.NearBy.Request.Location>();
            CreateMap<GoogleApi.Entities.Places.Search.NearBy.Request.Location, Location>();
            CreateMap<GoogleApi.Entities.Common.Location, Location>();
        }
    }
}