using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using yash.Data.EF;
using yash.Data.Entities;
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
    }
}

