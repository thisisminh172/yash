using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using yash.ViewModels.Users;
using yash.Data.Entities;

namespace yash.Application.Users
{
    public interface IUserService
    {
        Task<bool> Register(RegisterRequest request);
        Task<bool> Authenticate(LoginRequest request);
        Task<IEnumerable<User>> GetUser();
    }
}
