using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using yash.Utilities.Constants;

namespace yash.WebApp.Controllers
{
    public class CartsController : Controller
    {
        private string uri = UriConstants.URI_HOST_PORT_NUMBER_OF_API + "api/Carts/";

        public IActionResult Index(int userId)
        {
            HttpClient httpclient = new HttpClient();
            var userIdTemp = 1;
            return View();
        }
    }
}
