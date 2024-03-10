using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicentaApp.Data
{
    public interface IContactService
    {
        Task<List<Contact>> RefreshContactDataAsync();
        Task SaveContactAsync(Contact item, bool isNewItem);
        Task DeleteContactAsync(int Id);
    }
}
