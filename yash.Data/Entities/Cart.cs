using System;
using System.Collections.Generic;
using System.Text;

namespace yash.Data.Entities
{
    public class Cart
    {
        public int Id { get; set; }
        public int ItemId { get; set; }//FK
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int UserId { get; set; }//FK
        public DateTime DateCreated { get; set; }
        public User User { get; set; }
        public Item Item { get; set; }
    }
}
