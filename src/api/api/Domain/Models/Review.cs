namespace api.Domain.Models
{
    public class Review
    {
        private float _rating;
        public float Rating {
            get => _rating;
            set
            {
                if (value < 0)
                {
                    _rating = 0;
                }
                else if (value > 5f)
                {
                    _rating = 5;
                }
                else
                {
                    _rating = value;
                }
            } }
        
        public string Title { get; set; }
        
        public string Description { get; set; }
        
        public Bathroom Bathroom { get; set; }
    }
}