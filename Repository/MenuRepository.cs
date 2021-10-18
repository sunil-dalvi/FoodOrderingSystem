using FoodOrderingSystem.Contracts;
using FoodOrderingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrderingSystem.Repository
{
    public class MenuRepository : RepositoryBase<Menu>, IMenuRepository
    {
        public MenuRepository(FoodOrderingDBContext FoodOrderingDBContext)
            : base(FoodOrderingDBContext)
        {
        }
        
    }
}
