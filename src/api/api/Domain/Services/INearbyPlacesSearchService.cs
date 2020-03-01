using System.Collections.Generic;
using System.Threading.Tasks;
using api.Domain.Models;

namespace api.Domain.Services
{
    public interface INearbyPlacesSearchService
    {
        Task<IEnumerable<Bathroom>> GetNearbyPlacesAsync(PlaceSearchParameters searchParameters);
    }
}
