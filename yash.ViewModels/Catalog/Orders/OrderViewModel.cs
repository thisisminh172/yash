using System;
using System.Collections.Generic;
using System.Text;
using yash.ViewModels.Catalog.Carts;

namespace yash.ViewModels.Catalog.Orders
{
    public class OrderViewModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public DateTime OrderDate { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public List<CartViewModel> Carts { get; set; }
    }
}
