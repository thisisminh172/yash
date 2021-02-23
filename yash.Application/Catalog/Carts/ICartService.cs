using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using yash.Data.Entities;

namespace yash.Application.Catalog.Carts
{
    public interface ICartService
    {
        Task<List<Cart>> GetAll(int userId);
        Task<Cart> GetById(int cartId);
        Task<int> AddNewCart(int itemId);
        Task<int> UpdateCart(Cart cart);
        Task<int> DeleteCart(int cartId);
    }
}
