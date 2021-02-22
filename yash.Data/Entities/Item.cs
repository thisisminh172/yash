using System;
using System.Collections.Generic;
using System.Text;

namespace yash.Data.Entities
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //public int BrandId { get; set; }//FK

        public int Quantity { get; set; }//Storage

        public int CategoryId { get; set; }//FK

        //public string ProductQuality { get; set; }//not clear

        public int CertifyId { get; set; }//FK

        public int ProductId { get; set; }//FK

        public int GoldId { get; set; }//FK

        public int DiamondId { get; set; }// does not required, nullable

        public float DiamondCarat { get; set; }

        public float GoldWeight { get; set; }// ounce

        public int WastageInPercentage { get; set; }

        public float TotalMaking { get; set; }//total price

        public int RingSizeId { get; set; }

        public RingSize Size { get; set; }

        public Gold Gold { get; set; }
        public Diamond Diamond { get; set; }
        public Certification Certification { get; set; }
        public ProductType Product { get; set; }
        public Brand Brand { get; set; }
        public Category Category { get; set; }

        public List<ItemImage> ItemImages { get; set; }
        public List<Cart> Carts { get; set; }
    }
}
