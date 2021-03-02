using System;
using System.Collections.Generic;
using System.Text;

namespace yash.ViewModels.Catalog.Carts
{
    class CartUpdateRequest
    {
        public int ItemId { get; set; }//FK
        public int Quantity { get; set; }
        //public float Price { get; set; }
    }
}
