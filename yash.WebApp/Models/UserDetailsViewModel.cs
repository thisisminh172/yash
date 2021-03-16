using System;
using System.Collections.Generic;
using yash.Data.Entities;
using yash.ViewModels.Catalog.Orders;
using yash.ViewModels.Users;

namespace yash.WebApp.Models
{
    public class UserDetailsViewModel
    {
        public UserDetails User { get; set; }


        public List<UserDetails> UserDetails { get; set; }
        public List<UserOrder> UserOrders { get; set; }
        public List<UserOrderDetails> UserOrderDetails { get; set; }
    }
}
