using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using yash.Utilities.Constants;
using yash.ViewModels.Catalog.Carts;
using yash.WebApp.Models;

namespace yash.WebApp.Controllers
{
    public class CartsController : Controller
    {
        private string uri = UriConstants.URI_HOST_PORT_NUMBER_OF_API + "api/Carts/";

        public IActionResult Index(CartItemViewModel cart_list_update, string submitButton)
        {
            HttpClient httpclient = new HttpClient();

            if (!string.IsNullOrEmpty(submitButton))
            {
                switch (submitButton)
                {
                    case "Update":
                        for (var i = 0; i < cart_list_update.Carts.Count; i++)
                        {
                            var cartId = cart_list_update.Carts[i].Id;
                            var quantity = cart_list_update.Carts[i].Quantity;
                            var model = httpclient.PutAsJsonAsync(uri, new CartViewModel { Id = cartId, Quantity = quantity }).Result;

                        }
                        break;
                }


                //var temp = submitButton;
            }
            //int? userIdTemp = HttpContext.Session.GetInt32("id");
            //test>>>>
            int userIdTemp = 1;
            if (userIdTemp == null)
            {
                return RedirectToAction("Login", "UsersApp");
            }
            var result = JsonConvert.DeserializeObject<List<CartViewModel>>(httpclient.GetStringAsync(uri + "GetCarts/" + userIdTemp).Result);
            var number_of_items = 0;
            for(var i = 0; i < result.Count; i++)
            {
                number_of_items += result[i].Quantity;
            }
            HttpContext.Session.SetInt32("number_of_items", number_of_items);
            return View(new CartItemViewModel()
            {
                Carts = result
            });
        }


        public IActionResult AddNewCart(int itemId)
        {
            //int? userIdTemp = HttpContext.Session.GetInt32("id");
            int userIdTemp = 1;
            if (userIdTemp == null)
            {
                return RedirectToAction("Login", "UsersApp");
            }
            HttpClient httpclient = new HttpClient();
            var result = httpclient.PostAsJsonAsync(uri, new CartViewModel { ItemId = itemId, UserId = userIdTemp }).Result;
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int cartId)
        {
            HttpClient httpclient = new HttpClient();
            var result = httpclient.DeleteAsync(uri + cartId).Result;
            return RedirectToAction("Index");
        }
        
    }
}
