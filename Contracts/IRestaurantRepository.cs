using FoodOrderingSystem.Models;
using FoodOrderingSystem.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrderingSystem.Contracts
{
    public interface IRestaurantRepository : IRepositoryBase<Restaurant>
    {
        Task<List<ViewRestaurant>> GetRestaurantsWithReviews();

        List<Menu> GetAllMenus(string restaurantID);

        List<Review> GetAllReviews(string restaurantID);

        Task<int> AddRestaurant(Restaurant restaurant);

        Task<int> AddMenuForRestaurant(Menu menu);
    }
}
