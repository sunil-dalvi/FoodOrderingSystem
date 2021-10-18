using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrderingSystem.Models
{
    public class Booking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long BookingID { get; set; }
        [Required]
        [ForeignKey("UserID")]
        public string UserID { get; set; }
        [Required]
        [ForeignKey("RestaurantID")]
        public string RestaurantID { get; set; }
        public bool BookingStatus { get; set; }
        public bool CancellationStatus { get; set; }
    }
}
