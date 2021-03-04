using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using yash.Data.Entities;
using yash.Utilities.Constants;
using yash.ViewModels.Catalog.Carts;
using yash.ViewModels.Catalog.Orders;
using yash.ViewModels.Users;
using yash.WebApp.Models;

namespace yash.WebApp.Controllers
{
    public class OrdersController : Controller
    {
        private string cartURI = UriConstants.URI_HOST_PORT_NUMBER_OF_API + "api/Carts/";
        private string userURI = UriConstants.URI_HOST_PORT_NUMBER_OF_API + "api/Users/";
        private string orderURI = UriConstants.URI_HOST_PORT_NUMBER_OF_API + "api/Orders/";
        public IActionResult Index()
        {
            int? userId = HttpContext.Session.GetInt32("id");
            if (userId == null)
            {
                return RedirectToAction("Login","UsersApp");
            }
            HttpClient httpClient = new HttpClient();
            var user = JsonConvert.DeserializeObject<UserViewModel>(httpClient.GetStringAsync(userURI + userId).Result);
            var carts = JsonConvert.DeserializeObject<List<CartViewModel>>(httpClient.GetStringAsync(cartURI + "GetCarts/" + userId).Result);
            
            return View(new OrderDetailViewModel() {
                User = user,
                Carts = carts
            });
        }

        [HttpPost]
        public IActionResult Confirm()
        {
            int? userId = HttpContext.Session.GetInt32("id");
            if (userId == null)
            {
                return RedirectToAction("Login", "UsersApp");
            }
            HttpClient httpClient = new HttpClient();
            var result = httpClient.PostAsJsonAsync(orderURI, new OrderCreateRequest() { UserId = (int)userId }).Result;
            return RedirectToAction("Finished");
        }

        public IActionResult Finished()
        {
            return View();
        }
    }
}
