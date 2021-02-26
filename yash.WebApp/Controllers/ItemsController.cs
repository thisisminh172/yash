using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using yash.Utilities.Constants;
using yash.ViewModels.Catalog.Items;
using yash.WebApp.Models;

namespace yash.WebApp.Controllers
{
    public class ItemsController : Controller
    {
        private string uri = UriConstants.URI_HOST_PORT_NUMBER_OF_API + "api/Items/";
        public IActionResult Index(int categoryId = 0)
        {
            HttpClient httpclient = new HttpClient();
            if (categoryId != 0)
            {
                var items = JsonConvert.DeserializeObject<List<ItemViewModel>>(httpclient.GetStringAsync(uri+"GetItemsByCategory/"+categoryId).Result);
                return View(new ItemDetailViewModel()
                {
                    Items = items,
                });
            }
            else
            {
                var items = JsonConvert.DeserializeObject<List<ItemViewModel>>(httpclient.GetStringAsync(uri).Result);
                return View(new ItemDetailViewModel()
                {
                    Items = items,
                });
            }
            
            
        }

        [HttpGet]
        public IActionResult Details(int itemId)
        {
            HttpClient httpclient = new HttpClient();
            var temp = JsonConvert.DeserializeObject<ItemViewModel>(httpclient.GetStringAsync(uri + itemId).Result);
            return View(new ItemDetailViewModel()
            {
                Item = temp
            });
        }
    }
}
