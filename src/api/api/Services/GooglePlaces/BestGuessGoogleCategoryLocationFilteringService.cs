using System.Collections.Generic;
using System.Linq;
using api.Domain.Models;
using api.Domain.Services;
using GoogleApi.Entities.Common.Enums;
using GoogleApi.Entities.Places.Search.NearBy.Response;

namespace api.Services
{
    public class BestGuessGoogleCategoryLocationFilteringService : ILocationFilteringService
    {
        private readonly HashSet<PlaceLocationType> _expectedLocationTypes = new HashSet<PlaceLocationType>
        {
            PlaceLocationType.Airport,
            PlaceLocationType.Amusement_Park,
            PlaceLocationType.Aquarium,
            PlaceLocationType.Art_Gallery,
            PlaceLocationType.Bar,
            PlaceLocationType.Book_Store,
            PlaceLocationType.Bowling_Alley,
            PlaceLocationType.Cafe,
            PlaceLocationType.Campground,
            PlaceLocationType.Car_Dealer,
            PlaceLocationType.Car_Rental,
            PlaceLocationType.Casino,
            PlaceLocationType.City_Hall,
            PlaceLocationType.Convenience_Store,
            PlaceLocationType.Courthouse,
            PlaceLocationType.Department_Store,
            PlaceLocationType.Gas_Station,
            PlaceLocationType.Supermarket,
            PlaceLocationType.Grocery_Or_Supermarket,
            PlaceLocationType.Gym,
            PlaceLocationType.Hospital,
            PlaceLocationType.Library,
            PlaceLocationType.Lodging,
            PlaceLocationType.Movie_Theater,
            PlaceLocationType.Museum,
            PlaceLocationType.Night_Club,
            PlaceLocationType.Restaurant,
            PlaceLocationType.Shopping_Mall,
            PlaceLocationType.Spa,
            PlaceLocationType.Stadium,
            PlaceLocationType.University,
            PlaceLocationType.Zoo
        };

        public IEnumerable<NearByResult> FilterExpectedBathroomLocations(IEnumerable<NearByResult> originalLocations)
        {
            return originalLocations.Where(nearbyResult =>
                (from placeLocationType in nearbyResult.Types
                    where !(placeLocationType is null)
                    select (PlaceLocationType) placeLocationType)
                .Any(locationType => _expectedLocationTypes.Contains(locationType))).ToList();
        }
    }
}