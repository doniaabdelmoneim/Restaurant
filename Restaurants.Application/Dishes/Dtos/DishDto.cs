using Restaurants.Domain.Entities;


namespace Restaurants.Application.Dishes.Dtos
{
    public class DishDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public int? kiloCalories { get; set; }
        public decimal Price { get; set; }

        public static DishDto? fromEntity(Dish? dish)
        {
            if (dish is null) return null!;
            return new DishDto
            {
                Id = dish.Id,
                Name = dish.Name,
                Description = dish.Description,
                kiloCalories = dish.kiloCalories,
                Price = dish.Price
            };

        }
    }
}
