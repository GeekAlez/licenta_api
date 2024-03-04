using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LicentaApp.Data;
using LicentaApp.Models;

namespace LicentaApp.Data
{
    public class CategoryListDatabase
    {
        ICategoryService categoryService;
        public CategoryListDatabase(ICategoryService service)
        {
            categoryService = service;
        }
        public Task<List<Category>> GetCategoryAsync()
        {
            return categoryService.RefreshDataAsync();
        }

        public Task SaveCategoryAsync(Category item, bool isNewItem = true)
        {
            return categoryService.SaveCategoryAsync(item, isNewItem);
        }
        public Task DeleteCategoryAsync(Category item)
        {
            return categoryService.DeleteCategoryAsync(item.Id);
        }

    }
}

