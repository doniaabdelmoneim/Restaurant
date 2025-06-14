
using Microsoft.EntityFrameworkCore;
using Restaurants.Domain.Entities;
    using Restaurants.Infrastructure.Persistence;
using Restaurants.Domain.Repositories;

namespace Restaurants.Infrastructure.Repositories
{
    internal class RestaurantsRepository (RestaurantsDbContext dbContext): IRestaurantsRepository
    {

        public async Task<IEnumerable<Restaurant>> GetAllAsync()
        {
            var restaurants = await dbContext.Restaurants.ToListAsync();
            return restaurants;
        }

    }

}
