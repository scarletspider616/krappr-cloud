using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using api.Domain.Models;
using api.Domain.Services;
using AutoMapper;
using GoogleApi;
using GoogleApi.Entities.Places.Search.NearBy.Request;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using GoogleLocation = GoogleApi.Entities.Places.Search.NearBy.Request.Location;

namespace api.Services
{
    public class GoogleNearbyPlacesSearchService : INearbyPlacesSearchService
    {
        private const string GooglePlacesApiKeyConfigKey = "GOOGLE_PLACES_API_KEY";
        private readonly string _placesApiKey;
        private readonly ILogger<GoogleNearbyPlacesSearchService> _logger;
        private readonly IMapper _mapper;

        public GoogleNearbyPlacesSearchService(
            ILogger<GoogleNearbyPlacesSearchService> logger,
            IMapper mapper,
            IConfiguration configuration)
        {
            _logger = logger;
            _mapper = mapper;
            if (string.IsNullOrWhiteSpace(configuration[GooglePlacesApiKeyConfigKey]))
            {
                throw new ArgumentException("Requires google places api key in app settings");
            }

            _placesApiKey = configuration[GooglePlacesApiKeyConfigKey];
        }

        public async Task<IEnumerable<Bathroom>> GetNearbyPlacesAsync(PlaceSearchParameters searchParameters)
        {
            var request = _mapper.Map<PlacesNearBySearchRequest>(searchParameters);
            request.Key = _placesApiKey;
            var response = await GooglePlaces.NearBySearch.QueryAsync(request);
            return _mapper.Map<IEnumerable<Bathroom>>(response.Results);
        }
    }
}