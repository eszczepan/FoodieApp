﻿using FoodieApp.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace FoodieApp.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
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
            public IEnumerable<Restaurant> GetAll()
            {
                return from r in restaurants
                       orderby r.Name
                       select r;
            }
        }
    }
}
