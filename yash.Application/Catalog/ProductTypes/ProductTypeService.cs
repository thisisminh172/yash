using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using yash.Data.EF;
using yash.Data.Entities;
using yash.ViewModels.Catalog.ProductTypes;

namespace yash.Application.Catalog.ProductTypes
{
    public class ProductTypeService : IProductTypeService
    {
        private readonly YashDbContext _context;
        public ProductTypeService(YashDbContext context)
        {
            _context = context;
        }
        public async Task<int> Create(ProductTypeCreateRequest request)
        {
            var temp = new ProductType()
            {
                Name = request.Name,
            };
            _context.ProductTypes.Add(temp);
            await _context.SaveChangesAsync();
            return temp.Id;
        }

        public async Task<int> Delete(int productTypeId)
        {
            var deleteValue = await _context.ProductTypes.FindAsync(productTypeId);
            _context.ProductTypes.Remove(deleteValue);
            return await _context.SaveChangesAsync();
        }

        public async Task<List<ProductType>> GetAll()
        {
            var theLists = await _context.ProductTypes.ToListAsync();
            return theLists;
        }

        public async Task<ProductType> GetById(int productTypeId)
        {
            var value = await _context.ProductTypes.FindAsync(productTypeId);
            return value;
        }

        public async Task<int> Update(ProductTypeUpdateRequest request)
        {
            var temp = await _context.ProductTypes.FindAsync(request.Id);
            if (temp == null)
            {
                return -1;
            }
            temp.Name = request.Name;
            return await _context.SaveChangesAsync();
        }
    }
}
