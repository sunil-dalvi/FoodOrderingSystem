using FoodOrderingSystem.Contracts;
using FoodOrderingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrderingSystem.Repository
{
    public class ReviewRepository : RepositoryBase<Review>, IReviewRepository
    {
        public ReviewRepository(FoodOrderingDBContext FoodOrderingDBContext)
            : base(FoodOrderingDBContext)
        {
        }
        
    }
}
