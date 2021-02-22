using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using yash.Data.Entities;
using yash.Utilities.Constants;
using yash.ViewModels.Catalog.ProductTypes;

namespace yash.AdminApp.Controllers
{
    public class ProductTypesController : Controller
    {
        private string uri = UriConstants.URI_HOST_PORT_NUMBER_OF_API + "api/ProductTypes/";
        public IActionResult Index()
        {
            HttpClient httpclient = new HttpClient();
            var tempList = JsonConvert.DeserializeObject<List<ProductType>>(httpclient.GetStringAsync(uri).Result);
            return View(tempList);
        }
        [HttpGet]
        public IActionResult Details(int Id)
        {
            HttpClient httpclient = new HttpClient();
            var temp = JsonConvert.DeserializeObject<ProductType>(httpclient.GetStringAsync(uri + Id).Result);
            return View(temp);
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            HttpClient httpclient = new HttpClient();
            var category = JsonConvert.DeserializeObject<ProductType>(httpclient.GetStringAsync(uri + Id).Result);
            return View(category);
        }
        [HttpPost]
        public IActionResult Edit(ProductTypeUpdateRequest request)
        {
            HttpClient httpclient = new HttpClient();
            var result = httpclient.PutAsJsonAsync(uri, request).Result;
            return RedirectToAction("Edit", new { categoryId = request.Id });

        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(ProductTypeCreateRequest request)
        {
            HttpClient httpclient = new HttpClient();
            var result = httpclient.PostAsJsonAsync(uri, request).Result;
            return RedirectToAction("Index");

        }

        public IActionResult Delete(int Id)
        {
            HttpClient httpclient = new HttpClient();
            var result = httpclient.DeleteAsync(uri + Id).Result;
            return RedirectToAction("Index");

        }
    }
}
