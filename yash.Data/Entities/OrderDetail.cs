using System;
using System.Collections.Generic;
using System.Text;

namespace yash.Data.Entities
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int OrderId { set; get; }
        public int ItemId { set; get; }
        public int Quantity { set; get; }
        public decimal Price { set; get; }

        public Order Order { get; set; }

        public Item Item { get; set; }
    }
}
