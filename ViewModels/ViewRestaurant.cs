using FoodOrderingSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrderingSystem.ViewModels
{
    public class ViewRestaurant
    {
        [Key]
        public string RestaurantID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public bool PureVeg { get; set; }
        public double OverallRating { get; set; }
        public virtual List<Review> Reviews { get; set; }
    }
}
