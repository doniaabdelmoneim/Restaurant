using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurants.Application.Restaurants;

namespace Restaurants.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantsController(IRestaurantsService restaurantsService) : ControllerBase
    {
        // GET: api/restaurants
        [HttpGet]
        public async Task<IActionResult> GetAllRestaurants()
        {
            var restaurants = await restaurantsService.GetAllRestaurants();
            if (restaurants == null || !restaurants.Any())
            {
                return NotFound(new { Message = "No restaurants found." });
            }

            return Ok(restaurants);
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetRestaurantById(int id)
        {
            var restaurant = await restaurantsService.GetById(id);
            if (restaurant is null)
            {
                return NotFound(new { Message = $"Restaurant with ID {id} not found." });

            }

            return Ok(restaurant);

        }
    }
}
