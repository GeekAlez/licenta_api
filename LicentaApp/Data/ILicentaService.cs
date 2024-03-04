using LicentaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicentaApp.Data
{
    public interface ILicentaService<A>
    {
        Task<List<A>> RefreshDataAsync();
        Task SaveObjectAsync(A item, bool isNewItem);
        Task DeleteObjectAsync(A item);

    }
}
