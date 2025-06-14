
namespace Restaurants.Domain.Entities
{
    public class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public int? kiloCalories { get; set; }
        public decimal Price { get; set; }
        public int RestaurantId { get; set; } // Foreign key to the Restaurant entity
    }
}
