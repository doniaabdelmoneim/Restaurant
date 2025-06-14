
using Restaurants.Application.Dishes.Dtos;
using Restaurants.Domain.Entities;

namespace Restaurants.Application.Restaurants.Dtos
{
    public class RestaurantDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public string category { get; set; } = default!;
        public bool HasDelivery { get; set; }
        public string? city { get; set; }
        public string? street { get; set; }
        public string? postalCode { get; set; }

        //collections of dishes
        public List<DishDto> Dishes { get; set; } = new();

        //manal handling of the conversion from entity to DTO (like :autoMapper)
        public static RestaurantDto? fromEntity(Restaurant? restaurant)
        {
            if (restaurant is null) return null!; 
            
            return new RestaurantDto
            {
                Id = restaurant.Id,
                Name = restaurant.Name,
                Description = restaurant.Description,
                category = restaurant.category,
                HasDelivery = restaurant.HasDelivery,
                city = restaurant.address?.city,
                street = restaurant.address?.street,
                postalCode = restaurant.address?.postalCode,
                //Dishes = restaurant.Dishes.Select(d => new DishDto
                //{
                //    Id = d.Id,
                //    Name = d.Name,
                //    Description = d.Description,
                //    kiloCalories = d.kiloCalories,
                //    Price = d.Price,
                //    RestaurantId = d.RestaurantId
                //}).ToList()

            };
        } 
    }
}
