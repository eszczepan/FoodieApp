using FoodieApp.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodieApp.ViewComponents
{
    public class RestaurantCount : ViewComponent
    {
        private readonly IRestaurantData restaurantData;

        public RestaurantCount(IRestaurantData restaurantData)
        {
            this.restaurantData = restaurantData;
        }

        public IViewComponentResult Invoke()
        {
            var count = restaurantData.GetCountOfRestaurants();
            return View(count);
        }
    }
}
