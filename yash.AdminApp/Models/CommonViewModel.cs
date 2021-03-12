using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using yash.Data.Entities;

namespace yash.AdminApp.Models
{
    public class CommonViewModel
    {
        public List<Order> orders { get; set; }
        public int orderId { get; set; }
        public List<OrderDetail> orderDetails { get; set; }

        public int numberOfShippingOrder { get; set; }
        public int numberOfSuccessOrder { get; set; }
        public int numberOfcanceledOrder { get; set; }
        public int numberOfInProgressOrder { get; set; }
    }
}
