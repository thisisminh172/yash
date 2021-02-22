using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using yash.Data.Entities;
using yash.Utilities.Constants;

namespace yash.AdminApp.Controllers
{
    public class CategoriesController : Controller
    {
        private string uri = UriConstants.URI_HOST_PORT_NUMBER_OF_API + "api/Categories/";
        public IActionResult Index()
        {
            var httpclient = new HttpClient();
            var listCategories = JsonConvert.DeserializeObject<List<Category>>(httpclient.GetStringAsync(uri).Result);
            return View(listCategories);
        }


    }
}
