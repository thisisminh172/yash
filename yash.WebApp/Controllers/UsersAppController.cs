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
        [HttpGet]
        public async Task<IActionResult> Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(User model)
        {
            HttpClient httpClient = new HttpClient();
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
                    TempData["id"] = HttpContext.Session.GetInt32("id");
                    TempData["session"] = HttpContext.Session.GetString("name");
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.mess = "Invalid password";
                }
            }
            return View();
        }
    }
}
