using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrderingSystem.Models
{
    public class Table
    {
        [Key]
        [Column(Order = 1)]
        public int TableNumber { get; set; }
        [Key]
        [Column(Order = 2)]
        [ForeignKey("RestaurantID")]
        public long RestaurantID { get; set; }
        
        public bool TableStatus { get; set; }
    }
}
