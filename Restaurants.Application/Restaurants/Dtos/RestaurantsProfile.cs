
using AutoMapper;
using Restaurants.Domain.Entities;

namespace Restaurants.Application.Restaurants.Dtos
{
    public class RestaurantsProfile : Profile
    {
        public RestaurantsProfile()
        {

            // Mapping from createRestaurantDto to Restaurant, including nested Address mapping
            CreateMap<createRestaurantDto, Restaurant>()
                .ForMember(dest => dest.address, opt =>
                    opt.MapFrom(src => new Address
                    {
                        city = src.city,
                        street = src.street,
                        postalCode = src.postalCode
                    }));



            // Mapping from Restaurant entity to RestaurantDto
            CreateMap<Restaurant, RestaurantDto>()
                .ForMember(dest => dest.city, opt => 
                    opt.MapFrom(src => src.address==null? null : src.address.city))

                .ForMember(dest => dest.postalCode, opt =>
                    opt.MapFrom(src => src.address == null ? null : src.address.postalCode))

                .ForMember(dest => dest.street, opt =>
                    opt.MapFrom(src => src.address == null ? null : src.address.street))

                .ForMember(dest => dest.Dishes, opt =>
                    opt.MapFrom(src => src.Dishes));


        }
    }
}
