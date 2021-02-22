using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using yash.Data.Entities;

namespace yash.Application.Catalog.Categories
{
    public interface ICategoryService
    {
        Task<List<Category>> GetAll();
        Task<Category> GetById(int categoryId);
        Task<int> Create(Category newCategory);
        Task<int> Update(Category updateCategory);
        Task<int> Delete(int categoryId);
    }
}
