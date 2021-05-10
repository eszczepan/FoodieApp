using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodieApp.Core;
using FoodieApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FoodieApp.Pages.Restaurants
{
    public class DetailModel : PageModel
    {
        private readonly IRestaurantData restaurantData;

        public Restaurant Restaurant { get; set; }
        public DetailModel(IRestaurantData restaurantData)
        {
            this.restaurantData = restaurantData;
        }
        public IActionResult OnGet(int restaurantId)
        {

            Restaurant = restaurantData.GetById(restaurantId);
            if(Restaurant == null)
            {
                Console.WriteLine("Redirect");
                return RedirectToPage("./NotFound");
            }
            return Page();
        }
    }
}
