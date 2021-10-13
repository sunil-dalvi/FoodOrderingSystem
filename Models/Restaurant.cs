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
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long RestaurantID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public bool PureVeg { get; set; }
        public double OverallRating { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<Menu> Menus { get; set; }
        public virtual ICollection<Table> Tables { get; set; }
    }
}
