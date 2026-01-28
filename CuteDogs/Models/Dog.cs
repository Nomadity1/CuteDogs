namespace CuteDogs.Models
{
    public class Dog
    {
        // Properties
        public int Id { get; set; } // Unique identifier for each dog
        public string Name { get; set; } // Name of the dog
        public int Cuteness { get; set; } // Cuteness level (1-10)
        public string Image { get; set; } // Image URL
        public string FavFood { get; set; } // Favorite food
        public string FavToy { get; set; } // Favorite toy
        public int Temperament { get; set; } // Temperament level (1-10)
        public bool IsAdopted { get; set; } // Adoption status
    }
}
