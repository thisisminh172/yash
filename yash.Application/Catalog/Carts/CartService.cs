using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yash.Data.EF;
using yash.Data.Entities;

namespace yash.Application.Catalog.Carts
{
    public class CartService : ICartService
    {
        private readonly YashDbContext _context;
        public CartService(YashDbContext context)
        {
            _context = context;
        }
        public async Task<int> AddNewCart(int itemId)
        {
            //tim section userId CHUA CO
            var item = await _context.Items.FindAsync(itemId);
            var newCart = new Cart()
            {
                
                ItemId = itemId,
                Quantity = 1,
                Price = item.TotalMaking
            };
            _context.Carts.Add(newCart);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> DeleteCart(int cartId)
        {
            var cart = await _context.Carts.FindAsync(cartId);
            _context.Carts.Remove(cart);
            return await _context.SaveChangesAsync();
        }

        public async Task<List<Cart>> GetAll(int userId)
        {
            var cartList = await _context.Carts.Where(x => x.UserId == userId).ToListAsync();
            return cartList;
        }

        public async Task<Cart> GetById(int cartId)
        {
            var cart = await _context.Carts.FindAsync(cartId);
            return cart;
        }

        public async Task<int> UpdateCart(Cart cart)
        {
            var updateCart = await _context.Carts.FindAsync(cart.Id);
            updateCart.Quantity = cart.Quantity;
            updateCart.Price = cart.Quantity * cart.Price;
            return await _context.SaveChangesAsync();
            
        }
    }
}
