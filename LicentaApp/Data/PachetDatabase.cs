using LicentaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicentaApp.Data
{
    public class PachetDatabase
    {
        IPachetService pachetService;
        public PachetDatabase(IPachetService service)
        {
            pachetService = service;
        }
        public Task<List<Pachet>> GetPachetAsync()
        {
            return pachetService.RefreshPachetAsync();
        }

        public Task SavePachetAsync(Pachet item, bool isNewItem = true)
        {
            return pachetService.SavePachetAsync(item, isNewItem);
        }
        public Task DeletePachetAsync(Pachet item)
        {
            return pachetService.DeletePachetAsync(item.Id);
        }

    }
}
