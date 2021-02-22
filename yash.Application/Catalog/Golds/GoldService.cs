using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using yash.Data.EF;
using yash.Data.Entities;
using yash.ViewModels.Catalog.Golds;

namespace yash.Application.Catalog.Golds
{
    public class GoldService : IGoldService
    {
        private readonly YashDbContext _context;
        public GoldService(YashDbContext context)
        {
            _context = context;
        }
        public async Task<int> Create(GoldCreateRequest request)
        {
            var gold = new Gold()
            {
                GoldCarat = request.GoldCarat,
                Price = request.Price
            };
            _context.Golds.Add(gold);
            await _context.SaveChangesAsync();
            return gold.Id;
        }

        public async Task<int> Delete(int goldId)
        {
            var deleteValue = await _context.Golds.FindAsync(goldId);
            _context.Golds.Remove(deleteValue);
            return await _context.SaveChangesAsync();
        }

        public async Task<List<Gold>> GetAll()
        {
            var theLists = await _context.Golds.ToListAsync();
            return theLists;
        }

        public async Task<Gold> GetById(int goldId)
        {
            var value = await _context.Golds.FindAsync(goldId);
            return value;
        }

        public async Task<int> Update(GoldUpdateRequest request)
        {
            var temp = await _context.Golds.FindAsync(request.Id);
            if (temp == null)
            {
                return -1;
            }
            temp.GoldCarat = request.GoldCarat;
            temp.Price = request.Price;
            return await _context.SaveChangesAsync();
        }
    }
}
