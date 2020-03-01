using System.Collections.Generic;
using api.Domain.Models;
using GoogleApi.Entities.Places.Search.NearBy.Response;

namespace api.Domain.Services
{
    public interface ILocationFilteringService
    {
        public IEnumerable<NearByResult> FilterExpectedBathroomLocations(
            IEnumerable<NearByResult> originalLocations);
    }
}