using FoodOrderingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrderingSystem.Contracts
{
    public interface IUserRepository : IRepositoryBase<User>
    {
        Task<int> RegisterUser(User user);
    }
}
