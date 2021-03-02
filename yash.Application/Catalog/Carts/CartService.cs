using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yash.Data.EF;
using yash.Data.Entities;
using yash.ViewModels.Catalog.Carts;

namespace yash.Application.Catalog.Carts
{
    public class CartService : ICartService
    {
        private readonly YashDbContext _context;
        public CartService(YashDbContext context)
        {
            _context = context;
        }
        public async Task<int> AddNewCart(CartViewModel newCart)
        {
            //tim section userId CHUA CO
            var temp = _context.Carts.Where(x => x.UserId == newCart.UserId).ToList();
            var quantity = 1;
      
            foreach( var i in temp)
            {
                if(i.ItemId == newCart.ItemId)
                {
                    var itemPrice = _context.Items.Find(newCart.ItemId).TotalMaking;
                    i.Quantity += quantity;
                    i.Price = itemPrice * i.Quantity;
                }
                else
                {
                    var item = await _context.Items.FindAsync(newCart.ItemId);
                    var newCartTemp = new Cart()
                    {
                        ItemId = newCart.ItemId,
                        Quantity = quantity,
                        Price = item.TotalMaking,
                        UserId = newCart.UserId,
                        DateCreated = DateTime.Now,
                    };
                    _context.Carts.Add(newCartTemp);
                }
            }
            
            
            return await _context.SaveChangesAsync();
        }

        public async Task<int> DeleteCart(int cartId)
        {
            var cart = await _context.Carts.FindAsync(cartId);
            _context.Carts.Remove(cart);
            return await _context.SaveChangesAsync();
        }

        public List<CartViewModel> GetAll(int userId)
        {
            //var cartList = await _context.Carts.Where(x => x.UserId == userId).ToListAsync();
            var data = _context.Carts.Where(x => x.UserId == userId).ToList();
            //var data = (from c in _context.Carts
            //            where c.UserId == userId
            //            select new CartViewModel(){
            //                ItemId = c.ItemId,
            //                ItemName = _context.Items.Find(c.ItemId).Name,
            //                GoldName = _context.Golds.Find(_context.Items.Find(c.ItemId).GoldId).GoldCarat,
            //                DiamondName = _context.Diamonds.Find(_context.Items.Find(c.ItemId).DiamondId).DiamondShape,
            //                ProductTypeName = _context.ProductTypes.Find(_context.Items.Find(c.ItemId).ProductId).Name,
            //                Quantity = c.Quantity,
            //                DateCreated = c.DateCreated,
            //                Price = c.Price,
            //                ThumbnailImage = _context.ItemImages.FirstOrDefault(i => i.ItemId == c.ItemId && i.IsDefault == true).ItemImageUrl,
            //                UserId = c.UserId
            //            }).ToListAsync();

            var listCart = new List<CartViewModel>();
            foreach(var c in data)
            {
                var tempCart = new CartViewModel();
                tempCart.Id = c.Id;
                tempCart.UserId = userId;
                tempCart.ItemId = c.ItemId;
                tempCart.ItemName = _context.Items.Find(c.ItemId).Name;
                tempCart.GoldName = _context.Golds.Find(_context.Items.Find(c.ItemId).GoldId).GoldCarat;
                tempCart.DiamondName = _context.Diamonds.Find(_context.Items.Find(c.ItemId).DiamondId).DiamondShape;
                tempCart.ProductTypeName = _context.ProductTypes.Find(_context.Items.Find(c.ItemId).ProductId).Name;
                tempCart.DateCreated = c.DateCreated;
                tempCart.Price = c.Price;
                tempCart.ThumbnailImage = _context.ItemImages.FirstOrDefault(i => i.ItemId == c.ItemId && i.IsDefault == true).ItemImageUrl;
                tempCart.Quantity = c.Quantity;


                listCart.Add(tempCart);
            }
            
            return listCart;
        }

        public async Task<CartViewModel> GetById(int cartId)
        {
            

            var cartTemp = await _context.Carts.FindAsync(cartId);
            var cartView = new CartViewModel()
            {
                Id = cartTemp.Id,
                ItemId = cartTemp.ItemId,
                ItemName = _context.Items.Find(cartTemp.ItemId).Name,
                GoldName = _context.Golds.Find(_context.Items.Find(cartTemp.ItemId).GoldId).GoldCarat,
                DiamondName = _context.Diamonds.Find(_context.Items.Find(cartTemp.ItemId).DiamondId).DiamondShape,
                ProductTypeName = _context.ProductTypes.Find(_context.Items.Find(cartTemp.ItemId).ProductId).Name,
                Quantity = cartTemp.Quantity,
                DateCreated = cartTemp.DateCreated,
                Price = cartTemp.Price,
                ThumbnailImage = _context.ItemImages.FirstOrDefault(i => i.ItemId == cartTemp.ItemId && i.IsDefault == true).ItemImageUrl,
                UserId = cartTemp.UserId
            };
            
            return cartView;
            
        }

        public async Task<int> UpdateCart(CartViewModel updateCart)
        {
            var currentCart = await _context.Carts.FindAsync(updateCart.Id);
            currentCart.Quantity = updateCart.Quantity;
            currentCart.Price = updateCart.Quantity * _context.Items.Find(currentCart.ItemId).TotalMaking;
            return await _context.SaveChangesAsync();
            
        }
    }
}
