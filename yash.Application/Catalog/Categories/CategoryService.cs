using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yash.Data.EF;
using yash.Data.Entities;

namespace yash.Application.Catalog.Categories
{
    public class CategoryService : ICategoryService
    {
        private readonly YashDbContext _context;
        public CategoryService(YashDbContext context)
        {
            _context = context;
        }
        public async Task<int> Create(Category newCategory)
        {
            var category = await _context.Categories.FirstOrDefaultAsync(c => c.Name == newCategory.Name);
            if (category == null)
            {
                _context.Categories.Add(newCategory);
                await _context.SaveChangesAsync();
                return newCategory.Id;
            }
            return -1;
        }

        public async Task<int> Delete(int categoryId)
        {
            var category = await _context.Categories.FindAsync(categoryId);
            _context.Categories.Remove(category);
            return _context.SaveChanges();
        }

        public async Task<List<Category>> GetAll()
        {
            var categories = await _context.Categories.ToListAsync();
            return categories;
        }

        public async Task<Category> GetById(int categoryId)
        {
            var category = await _context.Categories.FindAsync(categoryId);
            return category;
        }

        public async Task<int> Update(Category updateCategory)
        {
            var category = await _context.Categories.FindAsync(updateCategory.Id);
            if (category == null)
            {
                return -1;
            }
            _context.Categories.Update(updateCategory);
            return await _context.SaveChangesAsync();
        }
    }
}
