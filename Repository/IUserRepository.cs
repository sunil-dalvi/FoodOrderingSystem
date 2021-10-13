using FoodOrderingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrderingSystem.Repository
{
    public interface IUserRepository
    {
        Task<int> RegisterUser(User user);
    }
}
