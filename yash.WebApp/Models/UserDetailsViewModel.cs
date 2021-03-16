using System;
using System.Collections.Generic;
using yash.Data.Entities;
using yash.ViewModels.Catalog.Orders;
using yash.ViewModels.Users;

namespace yash.WebApp.Models
{
    public class UserDetailsViewModel
    {
        //public UserDetails User { get; set; }
        public UserDetails UserDetails { get; set; }
        public UserOrder UserOrders { get; set; }
        public UserOrderDetails UserOrderDetails { get; set; }
    }
}
