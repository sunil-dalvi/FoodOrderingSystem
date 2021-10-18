using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrderingSystem.Models
{
    public class Review
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ReviewId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public double Rating { get; set; }
        public string Comment { get; set; }
        [Required]
        [ForeignKey("RestaurantID")]
        public string RestaurantID { get; set; }
        [Required]
        [ForeignKey("UserID")]
        public string UserID { get; set; }              
    }
}
