using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using yash.Data.Entities;
using yash.ViewModels.Catalog.Categories;

namespace yash.Application.Catalog.Categories
{
    public interface ICategoryService
    {
        Task<List<Category>> GetAll();
        Task<Category> GetById(int categoryId);
        Task<int> Create(CategoryCreateRequest newCategory);
        Task<int> Update(CategoryUpdateRequest updateCategory);
        Task<int> Delete(int categoryId);
    }
}
