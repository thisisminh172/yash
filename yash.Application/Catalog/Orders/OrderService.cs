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

        public async Task<List<Order>> GetAll()
        {
            var orders = await _context.Orders.ToListAsync();
            return orders;
        }

        public Task<List<OrderAdminViewModel>> GetAllOrderData()
        {


            //var data = _context.Orders.Select(x=>new OrderAdminViewModel()
            //{
            //    OrderId = x.Id,
            //    OrderDate = x.OrderDate,
            //    Status = x.Status,
            //    TotalOfPrice = _context.OrderDetails.Where(y=>y.OrderId==x.Id).Select(x=>x.Price).Sum()
            //}).ToListAsync();
            var query = from o in _context.Orders
                        select new { o };
            var data = query.Select(x => new OrderAdminViewModel()
            {
                OrderId = x.o.Id,
                OrderDate = x.o.OrderDate.ToString("MM,yyyy"),
                Status = x.o.Status,
                TotalOfPrice = _context.OrderDetails.Where(y=>y.OrderId==x.o.Id).Select(x=>x.Price).Sum()
            }).ToListAsync();
            return data;
        }

        public async Task<List<OrderDetailAdminViewModel>> GetAllOrderDetail(int orderId)
        {

            var query = from od in _context.OrderDetails
                        where od.OrderId == orderId
                        join i in _context.Items on od.ItemId equals i.Id
                        join pt in _context.ProductTypes on i.ProductId equals pt.Id
                        join c in _context.Certifications on i.CertifyId equals c.Id
                        join g in _context.Golds on i.GoldId equals g.Id
                        join d in _context.Diamonds on i.DiamondId equals d.Id
                        select new { od, i, pt, c, g, d };
            var data = await query.Select(x => new OrderDetailAdminViewModel()
            {
                Id = x.od.Id,
                OrderId = x.od.OrderId,
                ItemName = x.i.Name,
                ProductName = x.pt.Name,
                CertifyName = x.c.Name,
                GoldCaratName = x.g.GoldCarat,
                DiamondCarat = x.i.DiamondCarat,
                DiamondShape = x.d.DiamondShape,
                Quantity = x.od.Quantity,
                Price = x.od.Price
            }).ToListAsync();
            return data;

        }

        public async Task<int> UpdateOrder(Order request)
        {
            var order = await _context.Orders.FindAsync(request.Id);
            order.Status = request.Status;
            return await _context.SaveChangesAsync();
           
        }

        
    }
}
