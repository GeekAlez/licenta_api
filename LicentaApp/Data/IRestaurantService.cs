using LicentaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicentaApp.Data
{
    public interface IRestaurantService
    {
        Task<List<Restaurant>> RefreshRestaurantAsync();
        Task SaveRestaurantAsync(Restaurant item, bool isNewItem);
        Task DeleteRestaurantAsync(int Id);
    }
}
