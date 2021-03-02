using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using yash.Data.Entities;
using yash.ViewModels.Catalog.Carts;

namespace yash.Application.Catalog.Carts
{
    public interface ICartService
    {
        List<CartViewModel> GetAll(int userId);
        Task<CartViewModel> GetById(int cartId);
        Task<int> AddNewCart(int itemId, int userId);
        Task<int> UpdateCart(int itemId, int quantity);
        Task<int> DeleteCart(int cartId);
    }
}
