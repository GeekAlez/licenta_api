using LicentaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicentaApp.Data
{
    public interface ICategoryService
    {
        Task<List<Category>> RefreshDataAsync();
        Task SaveCategoryAsync(Category item, bool isNewItem);
        Task DeleteCategoryAsync(int Id);
    }
}
