using System;
using System.Collections.Generic;

namespace api.Domain.Models
{
    public class Bathroom
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        
        // assuming a 1 - 1 mapping between bathrooms and locations for now
        public Location Location { get; set; }
        
        public IEnumerable<Review> Reviews { get; set; }
    }
}