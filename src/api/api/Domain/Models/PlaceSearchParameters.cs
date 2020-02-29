namespace api.Domain.Models
{
    public class PlaceSearchParameters
    {
        private double _searchRadiusMeters;
        public Location SearchLocation { get; set; }

        public double SearchRadiusMeters
        {
            get => _searchRadiusMeters;
            set
            {
                if (value < 50.0 && value > 0.0)
                {
                    _searchRadiusMeters = value;
                }
                else
                {
                    _searchRadiusMeters = 50.0;
                }
            }
        }
    }
}