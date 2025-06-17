using Microsoft.Extensions.DependencyInjection;
using Restaurants.Application.Restaurants;
using FluentValidation;
using FluentValidation.AspNetCore;

namespace Restaurants.Application.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddApplication(this IServiceCollection services)
        {
            var applicationAssembly = typeof(ServiceCollectionExtensions).Assembly;
            // Register application services here
            services.AddScoped<IRestaurantsService, RestaurantsService>();
            services.AddAutoMapper(typeof(ServiceCollectionExtensions).Assembly);

            // Register FluentValidation validators if needed
            services.AddValidatorsFromAssembly(applicationAssembly)
                .AddFluentValidationAutoValidation();

        }
    }
}
