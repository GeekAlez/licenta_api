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
        ILicentaService restService;
        public WebAPIDatabase(ILicentaService service)
        {
            restService = service;
        }
        public Task<List<Pachet>> GetPachetsAsync()
        {
            return restService.RefreshDataAsync();
        }

        public Task SavePachetAsync(Pachet item, bool isNewItem = true)
        {
            return restService.SavePachetAsync(item, isNewItem);
        }
        public Task DeletePachetAsync(Pachet item)
        {
            return restService.DeletePachetAsync(item.Id);
        }

    }
}
