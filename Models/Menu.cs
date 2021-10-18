using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrderingSystem.Models
{
    public class Menu
    {
        [Key]
        [Column(Order = 1)]
        public string MenuName { get; set; }
        [Key]
        [Column(Order = 2)]
        [Required]
        [ForeignKey("RestaurantID")]
        public string RestaurantID { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }        
    }
}
