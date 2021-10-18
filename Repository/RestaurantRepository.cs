using FoodOrderingSystem.Contracts;
using FoodOrderingSystem.Models;
using FoodOrderingSystem.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrderingSystem.Repository
{
    public class RestaurantRepository : RepositoryBase<Restaurant>,IRestaurantRepository
    {
        public RestaurantRepository(FoodOrderingDBContext FoodOrderingDBContext)
            : base(FoodOrderingDBContext)
        {
            
        }
        public Task<int> AddMenuForRestaurant(Menu menu)
        {
            throw new NotImplementedException();
        }

        public Task<int> AddRestaurant(Restaurant restaurant)
        {
            throw new NotImplementedException();
        }

        public  List<Menu> GetAllMenus(string restaurantID)
        {
            if (FoodOrderingDBContext != null)
            {
                var menus =   FoodOrderingDBContext.Menues.Where(r => r.RestaurantID == restaurantID).ToList();
                return menus;
            }
            return null;
        }

        public   List<Review> GetAllReviews(string restaurantID)
        {
            if (FoodOrderingDBContext != null)
            {
                var reviews =  FoodOrderingDBContext.Reviews.Where(r => r.RestaurantID == restaurantID).ToList();
                return reviews;
            }
            return null;
        }

        public async Task<List<ViewRestaurant>> GetRestaurantsWithReviews()
        {
            if (FoodOrderingDBContext != null)
            {
                return await (from r in FoodOrderingDBContext.Restaurants
                              select new ViewRestaurant
                              {
                                  RestaurantID = r.RestaurantID,
                                  Name = r.Name,
                                  Address = r.Address,
                                  PureVeg = r.PureVeg,
                                  OverallRating = 4.5,
                                  Reviews = GetAllReviews(r.RestaurantID)
                              }).ToListAsync();                
            }

            return null;
        }
    }
}
