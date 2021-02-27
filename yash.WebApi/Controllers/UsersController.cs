using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using yash.Application.Users;
using yash.ViewModels.Users;

namespace yash.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IUserService userService;
        public UsersController(IUserService services)
        {
            this.userService = services;
        }
        [HttpGet]
        public async Task<IActionResult> Employees()
        {
            try
            {
                var users = await userService.GetUser();
                if (users == null)
                {
                    return NotFound();
                }
                return Ok(users);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPost]
        public async Task<IActionResult> Signup(RegisterRequest request)
        {
            var result = await userService.Register(request);
            if (result == true)
            {
                return Ok(request);
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login(LoginRequest loginRequest)
        {
            var result = await userService.Authenticate(loginRequest);
            if (result == true)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
