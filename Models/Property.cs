namespace PropertyRental.Models
{
    public class Property
    {
        public int Id {get; set;}
        public string Name {get; set;}

        public string Email {get; set;}

        public string PropertyType {get; set;}

        public int PropertyStories {get; set;}

        public int PropertySize {get; set;}

        public int Bedrooms {get; set;}

        public int Bathrooms {get; set;}

        public string OtherDetails {get; set;}
    }
}