using FoodieApp.Core;
using System.Collections.Generic;
using System.Text;

namespace FoodieApp.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetRestaurantsByName(string name);
        Restaurant Update(Restaurant updatedRestaurant);
        Restaurant Add(Restaurant newRestaurant);
        Restaurant Delete(int id);
        int GetCountOfRestaurants();
        int Commit();
        Restaurant GetById(int id);
    }
}
