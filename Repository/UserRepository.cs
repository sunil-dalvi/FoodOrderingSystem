using FoodOrderingSystem.Contracts;
using FoodOrderingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrderingSystem.Repository
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(FoodOrderingDBContext FoodOrderingDBContext)
            : base(FoodOrderingDBContext)
        {
        }
        public Task<int> RegisterUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
