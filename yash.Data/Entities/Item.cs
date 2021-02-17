using System;
using System.Collections.Generic;
using System.Text;

namespace yash.Data.Entities
{
    public class Item
    {
        public int Id { get; set; }

        public int Pairs { get; set; }//not clear

        public int BrandId { get; set; }//FK

        public int Quantity { get; set; }//Storage

        public int CategoryId { get; set; }//FK

        //public string ProductQuality { get; set; }//not clear

        public int CertifyId { get; set; }//FK

        public int ProductId { get; set; }//FK

        public int GoldTypeId { get; set; }//FK

        public int DiamondTypeId { get; set; }// does not required, nullable

        public float GoldWeight { get; set; }

        public int WastageInPercentage { get; set; }

        public float TotalMaking { get; set; }//total price

        public int Size { get; set; }

        public Gold Gold { get; set; }
        public Certification Certification { get; set; }
        public ProductType Product { get; set; }
        public Brand Brand { get; set; }
        public Category Category { get; set; }

        public List<ItemImage> ItemImages { get; set; }
        public List<Cart> Carts { get; set; }
    }
}
