﻿using System;
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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long MenuIdID { get; set; }
        public string MenuName { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public long RestaurantID { get; set; }
    }
}
