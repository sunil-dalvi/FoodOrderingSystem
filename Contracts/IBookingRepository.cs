using FoodOrderingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrderingSystem.Contracts
{
    public interface IBookingRepository : IRepositoryBase<Booking>
    {
        Task<Booking> BookTableInRestaurant(Restaurant restaurant);

        Task<Booking> GetBookingStatus(string UserId, string RestaurantID);
        Task<Booking> CancelBooking(string UserId, string RestaurantID);
    }
}
