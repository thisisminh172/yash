using System;
using System.Collections.Generic;
using System.Text;

namespace yash.ViewModels.Catalog.Carts
{
    public class CartViewModel
    {
        //this class is not have to use it
        //public int Id { get; set; }
        public int ItemId { get; set; }//FK
        public string ItemName { get; set; }
        public string GoldName { get; set; }
        public string DiamondName { get; set; }
        public string ProductTypeName { get; set; }

        public int Quantity { get; set; }
        public float Price { get; set; }
        public int UserId { get; set; }//FK
        public string ThumbnailImage { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
