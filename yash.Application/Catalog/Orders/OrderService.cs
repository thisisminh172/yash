using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yash.Data.EF;
using yash.Data.Entities;
using yash.ViewModels.Catalog.Orders;

namespace yash.Application.Catalog.Orders
{
    public class OrderService : IOrderService
    {
        private readonly YashDbContext _context;
        public OrderService(YashDbContext context)
        {
            _context = context;
        }
        public async Task<int> Create(OrderCreateRequest request)
        {
            var tempUser = await _context.Users.FindAsync(request.UserId);
            var tempCartList = await _context.Carts.Where(x => x.UserId == request.UserId).ToListAsync();
            var newOrder = new Order()
            {
                OrderDate = DateTime.Now,
                ShipAddress = tempUser.Address+" "+tempUser.City+" "+tempUser.State,
                ShipName = tempUser.FirstName+" "+tempUser.LastName,
                ShipEmail = tempUser.Email,
                ShipPhoneNumber = tempUser.PhoneNumber,
                UserId = tempUser.Id,
                Status = Data.Enums.OrderStatus.InProgress,
                OrderDetails = new List<OrderDetail>(),
            };
            
            for(var i=0; i < tempCartList.Count; i++)
            {
                var newOrderDetail = new OrderDetail()
                {
                    ItemId= tempCartList[i].ItemId,
                    Quantity = tempCartList[i].Quantity,
                    Price = tempCartList[i].Price,
                };
                await _context.OrderDetails.AddAsync(newOrderDetail);
                _context.Carts.Remove(tempCartList[i]);
                newOrder.OrderDetails.Add(newOrderDetail);
            }
            await _context.Orders.AddAsync(newOrder);
            return await _context.SaveChangesAsync();
        }
    }
}
