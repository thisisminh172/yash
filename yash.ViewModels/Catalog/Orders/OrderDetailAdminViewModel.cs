using System;
using System.Collections.Generic;
using System.Text;

namespace yash.ViewModels.Catalog.Orders
{
    public class OrderDetailAdminViewModel
    {
        public int Id { get; set; }
        public int OrderId { set; get; }
        public string ItemName { set; get; }
        public string ProductName { get; set; }
        public string CertifyName { get; set; }//FK
        public string GoldCaratName { get; set; }//FK
        public float DiamondCarat { get; set; }
        public string DiamondShape { get; set; }
        public int Quantity { get; set; }
        public float Price { set; get; }

    }
}
