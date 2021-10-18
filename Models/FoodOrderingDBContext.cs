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
        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<Menu> Menues { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
        public virtual DbSet<Table> Tables { get; set; } 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Menu>().HasKey(m => new { m.MenuName, m.RestaurantID });
            modelBuilder.Entity<Table>().HasKey(m => new { m.TableNumber, m.RestaurantID });

            modelBuilder.Entity<Restaurant>().HasData(new Restaurant
            {
                RestaurantID = "Rest101",
                Name = "Krishna Pure Veg",
                Address = "Near Mukai Chauk, Ravet",
                PureVeg = true,
                //OverallRating = 4.7
            }, new Restaurant
            {
                RestaurantID = "Rest102",
                Name = "Mezza9",
                Address = "Phase 1, Hinjewadi",
                PureVeg = false,
                //OverallRating = 4.5
            });
            modelBuilder.Entity<User>().HasData(new User
            {
                UserID = "sunildalvi",
                FirstName = "Sunil",
                LastName = "Dalvi",
                Email = "sunil123@gmail.com",
                PhoneNumber = "7588064645"
            }, new User
            {
                UserID = "sandippatil",
                FirstName = "Sandip",
                LastName = "Patil",
                Email = "sandip123@gmail.com",
                PhoneNumber = "9049276187"
            });
        }
    }
}
