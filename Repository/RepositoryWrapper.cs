using FoodOrderingSystem.Contracts;
using FoodOrderingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrderingSystem.Repository
{
    public class RepositoryWrapper
    {
        private FoodOrderingDBContext FoodOrderingDBContext;
        private IBookingRepository _booking;
        private IRestaurantRepository _restaurant;
        private IUserRepository _user;
        private IMenuRepository _menu;
        private IReviewRepository _review;

        public RepositoryWrapper(FoodOrderingDBContext FoodOrderingDBContext)
        {
            this.FoodOrderingDBContext = FoodOrderingDBContext;
        }
        public IBookingRepository booking
        {
            get
            {
                if (_booking == null)
                {
                    _booking = new BookingRepository(FoodOrderingDBContext);
                }
                return _booking;
            }
        }
        public IRestaurantRepository Restaurant
        {
            get
            {
                if (_restaurant == null)
                {
                    _restaurant = new RestaurantRepository(FoodOrderingDBContext);
                }
                return _restaurant;
            }
        }
        public IUserRepository User
        {
            get
            {
                if (_user == null)
                {
                    _user = new UserRepository(FoodOrderingDBContext);
                }
                return _user;
            }
        }
        public IMenuRepository Menu
        {
            get
            {
                if (_menu == null)
                {
                    _menu = new MenuRepository(FoodOrderingDBContext);
                }
                return _menu;
            }
        }
        public IReviewRepository Review
        {
            get
            {
                if (_review == null)
                {
                    _review = new ReviewRepository(FoodOrderingDBContext);
                }
                return _review;
            }
        }
        
        public void Save()
        {
            FoodOrderingDBContext.SaveChanges();
        }
    }
}

