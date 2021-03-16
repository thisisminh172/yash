using System;
using System.Collections.Generic;
using yash.Data.Entities;
using yash.ViewModels.Catalog.Orders;

namespace yash.ViewModels.Users
{
    public class UserDetails
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public DateTime DOB { get; set; }
        public string Password { get; set; }

        public List<UserOrder> Orders { get; set; }
        public List<UserOrderDetails> OrderDetails { get; set; }
    }
}
