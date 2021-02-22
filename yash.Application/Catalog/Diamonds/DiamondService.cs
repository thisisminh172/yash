using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using yash.Data.EF;
using yash.Data.Entities;
using yash.ViewModels.Catalog.Diamonds;

namespace yash.Application.Catalog.Diamonds
{
    public class DiamondService : IDiamondService
    {
        private readonly YashDbContext _context;
        public DiamondService(YashDbContext context)
        {
            _context = context;
        }
        public async Task<int> Create(DiamondCreateRequest request)
        {
            var diamond = new Diamond()
            {
                DiamondShape = request.DiamondShape,
                Price = request.Price
            };
            _context.Diamonds.Add(diamond);
            await _context.SaveChangesAsync();
            return diamond.Id;
        }

        public async Task<int> Delete(int diamondId)
        {
            var deleteDiamond = await _context.Diamonds.FindAsync(diamondId);
            _context.Diamonds.Remove(deleteDiamond);
            return await _context.SaveChangesAsync();
        }

        public async Task<List<Diamond>> GetAll()
        {
            var diamonds = await _context.Diamonds.ToListAsync();
            return diamonds;
        }

        public async Task<Diamond> GetById(int diamondId)
        {
            var diamond = await _context.Diamonds.FindAsync(diamondId);
            return diamond;
        }

        public async Task<int> Update(DiamondUpdateRequest request)
        {
            var diamond = await _context.Diamonds.FindAsync(request.Id);
            if (diamond == null)
            {
                return -1;
            }
            diamond.DiamondShape = request.DiamondShape;
            diamond.Price = request.Price;
            return await _context.SaveChangesAsync();
        }
    }
}
