using FoodOrderingSystem.Contracts;
using FoodOrderingSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrderingSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantController : ControllerBase
    {
        IRestaurantRepository restaurantRepository;
        public RestaurantController(IRestaurantRepository restaurantRepository)
        {
            this.restaurantRepository = restaurantRepository;
        }

        [HttpGet]
        [Route("GetRestaurantsWithReviews")]
        public async Task<IActionResult> GetRestaurantsWithReviews()
        {
            try
            {
                var restaurants = await restaurantRepository.GetRestaurantsWithReviews();
                if (restaurants == null)
                {
                    return NotFound();
                }

                return Ok(restaurants);
            }
            catch (Exception)
            {
                return BadRequest();
            }

        }
        [HttpPost]
        [Route("AddRestaurant")]
        public  IActionResult AddRestaurant([FromBody] Restaurant restaurant)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    restaurantRepository.Create(restaurant);
                    return Ok("Restaurant Created Successfully");
                }
                catch (Exception)
                {

                    return BadRequest();
                }

            }
            return BadRequest();
        }
    }
}
