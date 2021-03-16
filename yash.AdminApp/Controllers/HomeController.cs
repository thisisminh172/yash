using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using yash.AdminApp.Models;
using yash.Data.Entities;
using yash.Data.Enums;
using yash.Utilities.Constants;
using yash.ViewModels.Catalog.Orders;
using yash.ViewModels.Users;

namespace yash.AdminApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private string uri = UriConstants.URI_HOST_PORT_NUMBER_OF_API + "api/Orders/";
        private string userUri = UriConstants.URI_HOST_PORT_NUMBER_OF_API + "api/Users/";
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            HttpClient httpclient = new HttpClient();
            var tempList = JsonConvert.DeserializeObject<List<Order>>(httpclient.GetStringAsync(uri).Result);
            if (tempList == null)
            {
                return View(new CommonViewModel()
                {
                    orders = new List<Order>()
                    {
                        new Order()
                        {
                            ShipAddress = "empty",
                            ShipEmail = "empty",
                            ShipName = "empty",
                            ShipPhoneNumber = "empty",
                        }
                    }
                });
            }
            else {
                return View(new CommonViewModel()
                {
                    orders = tempList,
                    numberOfcanceledOrder = tempList.Where(x=>x.Status == OrderStatus.Canceled).ToList().Count,
                    numberOfShippingOrder = tempList.Where(x=>x.Status == OrderStatus.Shipping).ToList().Count,
                    numberOfInProgressOrder = tempList.Where(x=>x.Status == OrderStatus.InProgress).ToList().Count,
                    numberOfSuccessOrder = tempList.Where(x=>x.Status == OrderStatus.Success).ToList().Count,
                });
            }
            
        }
        [HttpPost]
        public IActionResult UpdateOrder(int orderId, OrderStatus orderStatus)
        {
            HttpClient httpclient = new HttpClient();
            //var tempList = JsonConvert.DeserializeObject<List<OrderDetail>>(httpclient.GetStringAsync(uri + "GetAllOrderDetail/" + orderId).Result);
            var result = httpclient.PutAsJsonAsync(uri + "UpdateOrder/", new Order() { Id = orderId, Status = orderStatus }).Result;
            return RedirectToAction("Index");
        }




        public IActionResult GetOrderDetail(int orderId, int userId)
        {
            HttpClient httpclient = new HttpClient();
            var tempList = JsonConvert.DeserializeObject<List<OrderDetailAdminViewModel>>(httpclient.GetStringAsync(uri+ "GetAllOrderDetail/"+orderId).Result);
            var user = JsonConvert.DeserializeObject<UserViewModel>(httpclient.GetStringAsync(userUri + userId).Result);

            //var query = 


            return View(new CommonViewModel()
            {
                orderId = orderId,
                orderDetailAdminViewModels = tempList,
                user = user
            }) ;
        }

        //show graph
        [HttpGet]
        public IActionResult ShowHistoty()
        {
            HttpClient httpclient = new HttpClient();
            var temp = JsonConvert.DeserializeObject<List<OrderAdminViewModel>>(httpclient.GetStringAsync(uri + "GetAllOrderData").Result);
                
            var data = temp.Where(x => x.Status == OrderStatus.Success).ToList();
            return View(new CommonViewModel() { 
                orderData = data
            });
        }

        //[HttpGet]
        //public IActionResult GetSuccessOrderData()
        //{
        //    HttpClient httpclient = new HttpClient();
        //    var data = JsonConvert.DeserializeObject<List<OrderDataAdminViewModel>>(httpclient.GetStringAsync(uri + "GetAllOrderData/").Result).Where(x => x.Status == OrderStatus.Success).Select(g => new { month = g.OrderDate.ToString("MM/yyyy"), total = g.TotalOfPrice }).ToList();
        //    return Json(data, System.Web.Mvc.JsonRequestBehavior.AllowGet);
        //}


        public IActionResult OrderListByStatus(OrderStatus orderStatus)
        {
            HttpClient httpclient = new HttpClient();
            var tempList = JsonConvert.DeserializeObject<List<Order>>(httpclient.GetStringAsync(uri).Result);
            if (tempList == null)
            {
                return View("~/Views/Home/Index.cshtml", new CommonViewModel()
                {
                    orders = new List<Order>()
                    {
                        new Order()
                        {
                            ShipAddress = "empty",
                            ShipEmail = "empty",
                            ShipName = "empty",
                            ShipPhoneNumber = "empty",
                        }
                    },
                    numberOfcanceledOrder = tempList.Where(x => x.Status == OrderStatus.Canceled).ToList().Count,
                    numberOfShippingOrder = tempList.Where(x => x.Status == OrderStatus.Shipping).ToList().Count,
                    numberOfInProgressOrder = tempList.Where(x => x.Status == OrderStatus.InProgress).ToList().Count,
                    numberOfSuccessOrder = tempList.Where(x => x.Status == OrderStatus.Success).ToList().Count
                });
            }
            else
            {
                return View("~/Views/Home/Index.cshtml", new CommonViewModel()
                {
                    orders = tempList.Where(x=>x.Status==orderStatus).ToList(),
                    numberOfcanceledOrder = tempList.Where(x => x.Status == OrderStatus.Canceled).ToList().Count,
                    numberOfShippingOrder = tempList.Where(x => x.Status == OrderStatus.Shipping).ToList().Count,
                    numberOfInProgressOrder = tempList.Where(x => x.Status == OrderStatus.InProgress).ToList().Count,
                    numberOfSuccessOrder = tempList.Where(x => x.Status == OrderStatus.Success).ToList().Count
                });
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
