using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrderingSystem.Models
{
    public class Restaurant
    {
        [Key]
        public string RestaurantID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        public bool PureVeg { get; set; }/*
        public double OverallRating { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<Menu> Menus { get; set; }
        public virtual ICollection<Table> Tables { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }*/
    }
}
