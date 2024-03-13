
using LicentaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicentaApp.Data
{
    public class RestaurantDatabase
    {
        IRestaurantService restaurantService;
        public RestaurantDatabase(IRestaurantService service)
        {
            restaurantService = service;
        }
        public Task<List<Restaurant>> GetRestaurantAsync()
        {
            return restaurantService.RefreshRestaurantAsync();
        }
       
        public Task SaveRestaurantAsync(Restaurant item, bool isNewItem = true)
        {
            return restaurantService.SaveRestaurantAsync(item, isNewItem);
        }
        public Task DeleteRestaurantAsync(Restaurant item)
        {
            return restaurantService.DeleteRestaurantAsync(item.Id);
        }

    }
}

