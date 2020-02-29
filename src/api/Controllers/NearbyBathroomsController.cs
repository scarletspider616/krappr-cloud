using System.Collections.Generic;
using System.Threading.Tasks;
using api.Domain.Models;
using api.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace api.Controllers
{
    public class NearbyBathroomsController : ControllerBase
    {
        private readonly ILogger<NearbyBathroomsController> _logger;
        private readonly INearbyPlacesSearchService _nearbyPlacesSearchService;

        public NearbyBathroomsController(
            ILogger<NearbyBathroomsController> logger,
            INearbyPlacesSearchService nearbyPlacesSearchService)
        {
            _logger = logger;
            _nearbyPlacesSearchService = nearbyPlacesSearchService;
        }

        // Currently disabling authorize for testing
        // [Authorize]
        [HttpPost]
        [Route("NearbyBathrooms/GetNearbyBathrooms")]
        public async Task<IEnumerable<Bathroom>> GetNearbyBathroomsAsync(
            [FromBody] NearbyBathroomsRequestModel nearbyBathroomsRequestModel)
        {
            var searchParams = new PlaceSearchParameters
            {
                SearchLocation = nearbyBathroomsRequestModel.Location,
                SearchRadiusMeters = nearbyBathroomsRequestModel.SearchRequestRadius,
            };

            return await _nearbyPlacesSearchService.GetNearbyPlacesAsync(searchParams);
        }
    }
}