using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using yash.Data.EF;
using yash.Data.Entities;
using yash.ViewModels.Catalog.RingSizes;

namespace yash.Application.Catalog.RingSizes
{
    public class RingSizeService : IRingSizeService
    {
        private readonly YashDbContext _context;
        public RingSizeService(YashDbContext context)
        {
            _context = context;
        }
        public async Task<int> Create(RingSizeCreateRequest request)
        {
            var temp = new RingSize()
            {
                SizeNumber = request.SizeNumber
            };
            _context.RingSizes.Add(temp);
            await _context.SaveChangesAsync();
            return temp.Id;
        }

        public async Task<int> Delete(int ringSizeId)
        {
            var deleteValue = await _context.RingSizes.FindAsync(ringSizeId);
            _context.RingSizes.Remove(deleteValue);
            return await _context.SaveChangesAsync();
        }

        public async Task<List<RingSize>> GetAll()
        {
            var theLists = await _context.RingSizes.ToListAsync();
            return theLists;
        }

        public async Task<RingSize> GetById(int ringSizeId)
        {
            var value = await _context.RingSizes.FindAsync(ringSizeId);
            return value;
        }

        public async Task<int> Update(RingSizeUpdateRequest request)
        {
            var temp = await _context.RingSizes.FindAsync(request.Id);
            if (temp == null)
            {
                return -1;
            }
            temp.SizeNumber = request.SizeNumber;
            return await _context.SaveChangesAsync();
        }
    }
}
