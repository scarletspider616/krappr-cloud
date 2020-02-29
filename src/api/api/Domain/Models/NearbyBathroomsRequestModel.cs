namespace api.Domain.Models
{
    public class NearbyBathroomsRequestModel
    {
        public Location Location { get; set; }
        public double SearchRequestRadius { get; set; }
    }
}