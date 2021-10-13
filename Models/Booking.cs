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
        public string UserID { get; set; }
        public string RestaurantID { get; set; }
        public bool BookingStatus { get; set; }
        public bool CancellationStatus { get; set; }
    }
}
