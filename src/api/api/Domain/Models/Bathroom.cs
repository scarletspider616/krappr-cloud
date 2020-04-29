using System.Collections.Generic;

namespace api.Domain.Models
{
    public class Bathroom
    {
        public string Name { get; set; }
        public Location Location { get; set; }
        
        public IEnumerable<Review> Reviews { get; set; }
    }
}