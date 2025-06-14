
using Microsoft.Extensions.Logging;
using Restaurants.Domain.Entities;
using Restaurants.Domain.Repositories;

namespace Restaurants.Application.Restaurants
{
   
        public class RestaurantsService(IRestaurantsRepository restaurantsRepository,
                 ILogger<RestaurantsService> logger):IRestaurantsService
        {
           
        public async Task<IEnumerable<Restaurant>> GetAllRestaurants()
        {
            logger.LogInformation("Fetching all restaurants from the repository.");
            var restaurants = await restaurantsRepository.GetAllAsync();  

            return restaurants;

        }

        public async Task<Restaurant?> GetById(int id)
        {
            logger.LogInformation($"Getting Restaurant {id}");
            var restaurant = await restaurantsRepository.GetByIdAsync(id);
            return restaurant;
        }
    }
}
