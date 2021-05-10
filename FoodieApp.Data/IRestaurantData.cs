using FoodieApp.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace FoodieApp.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetRestaurantsByName(string name);
        public class InMemoryRestaurantData : IRestaurantData
        {
            List<Restaurant> restaurants;
            public InMemoryRestaurantData()
            {
                restaurants = new List<Restaurant>()
                {
                    new Restaurant {Id = 1, Name = "Thomas's Pizza", Location = "Palermo", Cuisine = CuisineType.Italian},
                    new Restaurant {Id = 2, Name = "Phong Dong", Location = "California", Cuisine = CuisineType.Indian},
                    new Restaurant {Id = 3, Name = "The Dumplings", Location = "Cracow", Cuisine = CuisineType.Polish},
                };
            }
            public IEnumerable<Restaurant> GetRestaurantsByName(string name = null)
            {
                return from r in restaurants
                       where string.IsNullOrEmpty(name) || r.Name.StartsWith(name)
                       orderby r.Name
                       select r;
            }
        }
    }
}
