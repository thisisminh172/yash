using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using yash.Data.Entities;
using yash.Utilities.Constants;
using yash.ViewModels.Users;
using yash.WebApp.Models;


namespace yash.WebApp.Controllers
{
    public class UsersAppController : Controller
    {
        private string uri = UriConstants.URI_HOST_PORT_NUMBER_OF_API + "api/Users/";
        [HttpGet]
        public async Task<IActionResult> Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterRequest model)
        {
            HttpClient httpClient = new HttpClient();
            if (!ModelState.IsValid)
            {
                return View();
            }
            else
            {

                var newuser = httpClient.PostAsJsonAsync(uri, model).Result;
                if (newuser.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return View();
                }
            }
        }
        [HttpGet]
        public async Task<IActionResult> Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginRequest model)
        {
            HttpClient httpClient = new HttpClient();
            if (!ModelState.IsValid)
            {
                return View();
            }
            else
            {
                var data = JsonConvert.DeserializeObject<IEnumerable<User>>(httpClient.GetStringAsync(uri).Result);
                string email = model.Email;
                var user = data.FirstOrDefault(u => u.Email.Equals(email));
                if (user == null)
                {
                    ViewBag.mess = "Invalid Email";
                    return View();
                }
                else
                {
                    if (user.Password.Equals(model.Password))
                    {
                        HttpContext.Session.SetString("name", user.FirstName + " " + user.LastName);
                        HttpContext.Session.SetInt32("id", user.Id);
                        return RedirectToAction("Index", "Items");
                    }
                    else
                    {
                        ViewBag.mess = "Invalid password";
                    }
                    return View();
                }

            }

        }
        [HttpPost]
        public async Task<IActionResult> LogOut()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public async Task<IActionResult> ChangePass(int id)
        {
            HttpClient httpClient = new HttpClient();
            if (id > 0)
            {
                var user = JsonConvert.DeserializeObject<User>(httpClient.GetStringAsync(uri + id).Result);
                return View(user);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ChangePass(User pUser)
        {
            HttpClient httpClient = new HttpClient();
            var update = httpClient.PutAsJsonAsync(uri, pUser).Result;
            if (update.IsSuccessStatusCode)
            {
                HttpContext.Session.Clear();
                return RedirectToAction("Login");
            }
            ViewBag.mess = "Password change failed";
            return View(pUser.Id);
        }
        [HttpGet]
        public async Task<IActionResult> UserDetails(int id)
        {
            HttpClient httpClient = new HttpClient();
            var user = JsonConvert.DeserializeObject<UserDetails>(httpClient.GetStringAsync(uri + "GetUserDetail/" + id).Result);
            var userDetails = new UserDetailsViewModel()
            {
                User = user
            };
            return View(userDetails);
        }
    }
}
