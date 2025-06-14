
using Restaurants.Infrastructure.Persistence;
using Restaurants.Domain.Entities;

namespace Restaurants.Infrastructure.Seeders
{
    internal class RestaurantSeeder(RestaurantsDbContext dbContext) : IRestaurantSeeder
    {

        public async Task Seed()
        {
            // check if can I connect to database
            if (await dbContext.Database.CanConnectAsync())
            {
                if (!dbContext.Restaurants.Any())
                {
                    var restaurants = GetRestaurants();
                    dbContext.Restaurants.AddRange(restaurants);
                    await dbContext.SaveChangesAsync();
                }
            }
        }

        private IEnumerable<Restaurant> GetRestaurants()
        {
            return new List<Restaurant>
            {
                new Restaurant
                {
                    Name = "Atawich",
                    address = new Address
                    {
                        city = "Tehran",
                        postalCode = "123123123",
                        street = "Marzdaran"
                    },
                    category = "FastFood",
                    contactEmail = "Ata@wich.com",
                    contactNumber = "123123123",
                    Description = "Description",
                    Dishes = new List<Dish>
                    {
                        new Dish
                        {
                            Name = "Pizza",
                            Price = 1230000,
                            Description = "Description",
                        },
                        new Dish
                        {
                            Name = "Sandwich",
                            Price = 1200000,
                            Description = "Description",
                        },
                    },
                },
                new Restaurant
                {
                    Name = "Roohi",
                    address = new Address
                    {
                        city = "Tehran",
                        postalCode = "123123123",
                        street = "SaadatAbad"
                    },
                    category = "Sonnati",
                    contactEmail = "Roo@hi.com",
                    contactNumber = "13123123",
                    Description = "Description",
                    Dishes = new List<Dish>
                    {
                        new Dish
                        {
                            Name = "Kebab",
                            Price = 1231100,
                            Description = "Description",
                        },
                        new Dish
                        {
                            Name = "Dizi",
                            Price = 1200900,
                            Description = "Description",
                        },
                    },
                },
            };
        }
    }
}
