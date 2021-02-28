using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace yash.WebApp.Models
{
    public class CartItemViewModel
    {
        public int ItemId { get; set; }//FK
        public string ItemName { get; set; }
        public string GoldName { get; set; }
        public string DiamondName { get; set; }
        public string ProductTypeName { get; set; }

        public int Quantity { get; set; }
        public float Price { get; set; }
        public int UserId { get; set; }//FK
        public DateTime DateCreated { get; set; }
    }
}
