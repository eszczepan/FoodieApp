using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FoodieApp.Core
{
    public class Restaurant
    {
        public int Id { get; set; }

        [Required, StringLength(30)]
        public string Name { get; set; }
        [Required, StringLength(60)]
        public string Location { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}
