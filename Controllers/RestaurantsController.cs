using Microsoft.AspNetCore.Mvc;
using foodies.Models;

namespace foodies.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RestaurantsController : Controller
    {
        private readonly foodiesdbContext _context;

        public RestaurantsController(foodiesdbContext context)
        {
            _context = context;            
        }

        [HttpGet]
        public ActionResult<IEnumerable<Restaurant>> GetRestaurants()
        {
            return _context.Restaurants.ToList();
        }
        [HttpPost]
        public ActionResult<Restaurant> PostRestaurant(Restaurant restaurant)
        {
            _context.Restaurants.Add(restaurant);
            Console.WriteLine(restaurant.Id);           
            _context.SaveChanges();

            return new OkResult();
        }
    }
}
