using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LicentaApp.Models;

namespace LicentaApp.Data
{
    public class WebAPIDatabase
    {
        ILicentaService<A> restService;
        public WebAPIDatabase(ILicentaService<A> service)
        {
            restService = service;
        }
        public Task<List<A>> GetObjectsAsync()
        {
            return restService.RefreshDataAsync();
        }

        public Task SaveObjectAsync(A item, bool isNewItem = true)
        {
            return restService.SaveObjectAsync( item, isNewItem);
        }
        public Task DeleteObjectAsync(A item)
        {
            return restService.DeleteObjectAsync(item);
        }

    }
}
