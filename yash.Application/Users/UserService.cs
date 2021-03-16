using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using yash.Data.EF;
using yash.Data.Entities;
using yash.ViewModels.Catalog.Orders;
using yash.ViewModels.Users;

namespace yash.Application.Users
{
    public class UserService : IUserService
    {
        YashDbContext db;
        public UserService(YashDbContext dbContext)
        {
            db = dbContext;
        }
        public async Task<bool> Authenticate(LoginRequest request)
        {
            if (db.Users != null)
            {
                var user = await db.Users.FirstOrDefaultAsync(u => u.Email.Equals(request.Email) && u.Password.Equals(request.Password));
                if (user == null)
                {
                    return false;
                }
                return true;
            }
            return false;
        }

        public async Task<bool> changPass(User user)
        {
            if (user != null)
            {
                var u = await db.Users.FindAsync(user.Id);
                u.Password = user.Password;
                db.Users.Update(u);
                await db.SaveChangesAsync();
                return true;
            }
            return false;
        }
        public async Task<UserViewModel> CheckUser(int id)
        {
            if (id > 0 && db.Users != null)
            {
                var request = await db.Users.FindAsync(id);
                var user = new UserViewModel()
                {
                    Id = request.Id,
                    FirstName = request.FirstName,
                    LastName = request.LastName,
                    Address = request.Address,
                    City = request.City,
                    State = request.State,
                    PhoneNumber = request.PhoneNumber,
                    Email = request.Email,
                    DOB = request.DOB,
                    CurrentDate = request.CurrentDate,
                    Password = request.Password
                };
                return user;
            }
            return null;
        }
        public async Task<IEnumerable<User>> GetUser()
        {
            if (db.Users != null)
            {
                var user = await db.Users.ToListAsync();
                return user;
            }
            return null;
        }

        public async Task<bool> Register(RegisterRequest request)
        {
            if (request != null)
            {
                var check = await db.Users.FirstOrDefaultAsync(u => u.Email.Equals(request.Email));
                if (check != null)
                {
                    return false;
                }
                else
                {
                    var user = new Data.Entities.User()
                    {
                        FirstName = request.FirstName,
                        LastName = request.LastName,
                        Address = request.Address,
                        City = request.City,
                        State = request.State,
                        PhoneNumber = request.PhoneNumber,
                        Email = request.Email,
                        DOB = request.DOB,
                        CurrentDate = DateTime.Now,
                        Password = request.Password
                    };
                    await db.Users.AddAsync(user);
                    await db.SaveChangesAsync();
                    return true;
                }
            }
            return false;
        }

        public async Task<UserDetails> UserDetails(int id)
        {
            if (id > 0 && db.Users != null)
            {

                var user = await db.Users.FindAsync(id);
                //var orders = await db.Orders.Where(x => x.UserId == user.Id).ToListAsync();
                var data = new UserDetails()
                {
                    Id = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Address = user.Address,
                    City = user.City,
                    State = user.State,
                    PhoneNumber = user.PhoneNumber,
                    Email = user.Email,
                    DOB = user.DOB,
                    Orders  = (from order in db.Orders
                               where order.UserId ==user.Id
                               select new UserOrder()
                               {
                                   Id = order.Id,
                                   OrderDate = order.OrderDate,
                                   ShipName = order.ShipName,
                                   ShipAddress = order.ShipAddress,
                                   ShipEmail = order.ShipEmail,
                                   ShipPhoneNumber = order.ShipPhoneNumber,
                                   Status = order.Status,
                                   OrderDetails = (from orderDetail in db.OrderDetails
                                                   where orderDetail.OrderId == order.Id
                                                   select new UserOrderDetails()
                                                   {
                                                       Id = orderDetail.Id,
                                                       OrderId = orderDetail.OrderId,
                                                       ItemId = orderDetail.ItemId,
                                                       Quantity = orderDetail.Quantity,
                                                       Price = orderDetail.Price,
                                                       ItemName = db.Items.FirstOrDefault(x=>x.Id==orderDetail.ItemId).Name
                                                   }).ToList()
                               }).ToList(),
                };
                //var query = from u in db.Users
                //            where u.Id == id
                //            join o in db.Orders on u.Id equals o.UserId into uo
                //            from o in uo.DefaultIfEmpty()
                //            join od in db.OrderDetails on o.Id equals od.OrderId into uod
                //            from od in uod.DefaultIfEmpty()
                //            join itemname in db.Items on od.ItemId equals itemname.Id into iname
                //            from itemname in iname.DefaultIfEmpty()
                //            select new { u, o, od, itemname };
                //var data = await query
                //    .Select(x => new UserDetails()
                //    {
                //        Id = x.u.Id,
                //        FirstName = x.u.FirstName,
                //        LastName = x.u.LastName,
                //        Address = x.u.Address,
                //        City = x.u.City,
                //        State = x.u.State,
                //        PhoneNumber = x.u.PhoneNumber,
                //        Email = x.u.Email,
                //        DOB = x.u.DOB,
                //        Orders = (from order in db.Orders
                //                  where order.Id == x.o.Id
                //                  select new UserOrder()
                //                  {
                //                      Id = order.Id,
                //                      OrderDate = order.OrderDate,
                //                      ShipName = order.ShipName,
                //                      ShipAddress = order.ShipAddress,
                //                      ShipEmail = order.ShipEmail,
                //                      ShipPhoneNumber = order.ShipPhoneNumber,
                //                      Status = order.Status
                //                  }).ToList(),
                //        OrderDetails = (from orderDetail in db.OrderDetails
                //                        where orderDetail.Id == x.od.Id
                //                        select new UserOrderDetails()
                //                        {
                //                            Id = orderDetail.Id,
                //                            OrderId =orderDetail.OrderId,
                //                            ItemId = orderDetail.ItemId,
                //                            Quantity = orderDetail.Quantity,
                //                            Price = orderDetail.Price,
                //                            ItemName = x.itemname.Name
                //                        }).ToList()
                //    }).ToListAsync();
                return data;
            }
            return null;
        }
    }
}


