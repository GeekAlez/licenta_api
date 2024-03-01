using LicentaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicentaApp.Data
{
    public interface ILicentaService
    {
        Task<List<Pachet>> RefreshDataAsync();
        Task SavePachetAsync(Pachet item, bool isNewItem);
        Task DeletePachetAsync(int id);
    }
}
