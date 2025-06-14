
using Microsoft.Extensions.Logging;
using Restaurants.Application.Restaurants.Dtos;
using Restaurants.Domain.Entities;
using Restaurants.Domain.Repositories;

namespace Restaurants.Application.Restaurants
{
   
        public class RestaurantsService(IRestaurantsRepository restaurantsRepository,
                 ILogger<RestaurantsService> logger):IRestaurantsService
        {
           
        public async Task<IEnumerable<RestaurantDto>> GetAllRestaurants()
        {
            logger.LogInformation("Fetching all restaurants from the repository.");
            var restaurants = await restaurantsRepository.GetAllAsync();
            var restaurantDto = restaurants.Select(RestaurantDto.fromEntity);

            return restaurantDto!;

        }

        public async Task<RestaurantDto?> GetById(int id)
        {
            logger.LogInformation($"Getting Restaurant {id}");
            var restaurant = await restaurantsRepository.GetByIdAsync(id);
            var restaurantDto = RestaurantDto.fromEntity(restaurant);
            return restaurantDto;
        }
    }
}
