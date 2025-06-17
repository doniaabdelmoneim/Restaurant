using System.ComponentModel.DataAnnotations;
namespace Restaurants.Application.Restaurants.Dtos
{
    public class createRestaurantDto
    {
        [StringLength(100,MinimumLength = 3)]
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        [Required(ErrorMessage = "Insert a valid Category")]
        public string category { get; set; } = default!;
        public bool HasDelivery { get; set; }

        [EmailAddress(ErrorMessage = "please provide a valid email address")]
        public string? contactEmail { get; set; }
        [Phone(ErrorMessage = "Please Provide a Valid Phone Number")]
        public string? contactNumber { get; set; }
        public string? city { get; set; }

        public string? street { get; set; }
        [RegularExpression(@"^\d{2}-\d{3}$", ErrorMessage = "please provide a valid postal code (xx-xxx) ")]
        public string? postalCode { get; set; }
    }
}
