using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrderingSystem.Models
{
    public class FoodOrderingDBContext : DbContext
    {
        public FoodOrderingDBContext()
        {
        }

        public FoodOrderingDBContext(DbContextOptions<FoodOrderingDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Restaurant> Restaurants { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
