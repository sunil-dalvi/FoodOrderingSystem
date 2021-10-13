using FoodOrderingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrderingSystem.Repository
{
    public interface IRestaurantRepository
    {
        Task<List<Restaurant>> GetRestaurants();

        Task<List<Menu>> GetAllMenus();

        Task<int> AddRestaurant(Restaurant restaurant);

        Task<int> AddMenuForRestaurant(Menu menu);
    }
}
