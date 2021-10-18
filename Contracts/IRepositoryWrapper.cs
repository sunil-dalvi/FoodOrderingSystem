using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrderingSystem.Contracts
{
    public interface IRepositoryWrapper
    {
        IBookingRepository Booking { get; }
        IRestaurantRepository Restaurant { get; }
        IUserRepository User { get; }
        IMenuRepository Menu { get; }
        IReviewRepository Review { get; }
        void Save();
    }
}
