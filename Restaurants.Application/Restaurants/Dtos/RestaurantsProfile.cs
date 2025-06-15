using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Restaurants.Domain.Entities;

namespace Restaurants.Application.Restaurants.Dtos
{
    public class RestaurantsProfile : Profile
    {
        public RestaurantsProfile()
        {
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
