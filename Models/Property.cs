namespace PropertyRental.Models
{
    public class Property
    {
        public int Id { get; set; }
        public string name { get; set; }

        public string email { get; set; }

        public string title { get; set; }

        public decimal price { get; set; }

        public string propertyType { get; set; }

        public int propertyStories { get; set; }

        public int propertySize { get; set; }

        public int bedrooms { get; set; }

        public int bathrooms { get; set; }

        public bool parking { get; set; }

        public string imageUrl { get; set; }

        public string otherDetails { get; set; }
    }
}
