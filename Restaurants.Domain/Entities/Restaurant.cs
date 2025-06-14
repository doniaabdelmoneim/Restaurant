
namespace Restaurants.Domain.Entities
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }=default!;
        public string Description { get; set; } = default!;
        public string category { get; set; } = default!;
        public bool HasDelivery { get; set; } 

        public string? contactEmail { get; set; }
        public string? contactNumber { get; set; }
        public Address? address { get; set; }

        //collecttions of dishes
        public List<Dish> Dishes { get; set; } = new ();






    }
}
