using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using yash.Utilities.Constants;
using yash.ViewModels.Catalog.Items;
using yash.WebApp.Models;

namespace yash.WebApp.Controllers
{
    public class ItemsController : Controller
    {
        private string uri = UriConstants.URI_HOST_PORT_NUMBER_OF_API + "api/Items/";
        public IActionResult Index(int categoryId = 0, int selectedOption = 0)
        {
            HttpClient httpclient = new HttpClient();
            if(selectedOption==0)
            {
                if (categoryId != 0)
                {
                    var items = JsonConvert.DeserializeObject<List<ItemViewModel>>(httpclient.GetStringAsync(uri + "GetItemsByCategory/" + categoryId).Result);
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
            else
            {
                List<ItemViewModel> tempList;
                var items = JsonConvert.DeserializeObject<List<ItemViewModel>>(httpclient.GetStringAsync(uri).Result);

                switch (selectedOption)
                {
                    case 1:
                        tempList = items.OrderBy(x => x.Name).ToList();
                        return View(new ItemDetailViewModel()
                        {
                            Items = tempList,
                        });
                    case 2:
                        tempList = items.OrderByDescending(x => x.Name).ToList();
                        return View(new ItemDetailViewModel()
                        {
                            Items = tempList,
                        });
                    case 3:
                        tempList = items.OrderBy(x => x.TotalMaking).ToList();
                        return View(new ItemDetailViewModel()
                        {
                            Items = tempList,
                        });
                    case 4:
                        tempList = items.OrderByDescending(x => x.TotalMaking).ToList();
                        return View(new ItemDetailViewModel()
                        {
                            Items = tempList,
                        });
                    default:
                        return RedirectToAction("Index");

                }
            }
            
        }
        [HttpGet]
        public IActionResult Search(string name)
        {
            HttpClient httpClient = new HttpClient();
            var items = JsonConvert.DeserializeObject<List<ItemViewModel>>(httpClient.GetStringAsync(uri + "SearchItem/" + name).Result);
            if (items.Count >0)
            {
                return View(new ItemDetailViewModel()
                {
                    Items = items,
                });
            }
            else
            {
                TempData["searchmess"] = "Item does not exist!!!";
                return RedirectToAction("Index", "Items");
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

        [HttpPost]
        public IActionResult GetItemByPrice(int SelectOption = 0)
        {
         return RedirectToAction("Index", "Items", new { selectedOption = SelectOption });
        }
    }
}
