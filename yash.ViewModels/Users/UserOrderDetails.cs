using System;
using System.Collections.Generic;
using System.Text;
using yash.ViewModels.Catalog.Items;

namespace yash.ViewModels.Users
{
    public class UserOrderDetails
    {
        public int Id { get; set; }
        public int OrderId { set; get; }
        public int ItemId { set; get; }
        public int Quantity { get; set; }
        public float Price {get; set; }
        public string ItemName { get; set; }
    }
}
