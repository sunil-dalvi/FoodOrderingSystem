using FoodOrderingSystem.Contracts;
using FoodOrderingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrderingSystem.Repository
{
    public class BookingRepository : RepositoryBase<Booking>, IBookingRepository
    {
        public BookingRepository(FoodOrderingDBContext FoodOrderingDBContext) 
            : base(FoodOrderingDBContext)
        { 
        }
        public Task<Booking> BookTableInRestaurant(Restaurant restaurant)
        {
            throw new NotImplementedException();
        }

        public Task<Booking> CancelBooking(string UserId, string RestaurantID)
        {
            throw new NotImplementedException();
        }

        public Task<Booking> GetBookingStatus(string UserId, string RestaurantID)
        {
            throw new NotImplementedException();
        }
    }
}
