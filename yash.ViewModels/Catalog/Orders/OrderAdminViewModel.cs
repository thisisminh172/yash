using System;
using System.Collections.Generic;
using System.Text;
using yash.Data.Enums;

namespace yash.ViewModels.Catalog.Orders
{
    public class OrderAdminViewModel
    {
        public int OrderId { get; set; }
        public string OrderDate { get; set; }
        public OrderStatus Status { get; set; }
        public float TotalOfPrice { get; set; }
    }
}
