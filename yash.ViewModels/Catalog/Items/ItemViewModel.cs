using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using yash.Data.Entities;
using yash.ViewModels.Catalog.ItemImages;

namespace yash.ViewModels.Catalog.Items
{
    public class ItemViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //public int BrandId { get; set; }//FK


        public string CategoryName { get; set; }//FK

        //public string ProductQuality { get; set; }//not clear

        public string CertifyName { get; set; }//FK

        public string ProductName { get; set; }//FK

        public string GoldCaratName { get; set; }//FK

        public string DiamondShapeName { get; set; }// does not required, nullable

        public float DiamondCarat { get; set; }

        public float GoldWeight { get; set; }// ounce

        public int WastageInPercentage { get; set; }

        public float TotalMaking { get; set; }//total price

        public int RingSizeNumber { get; set; }
        public string ThumbnailImage { get; set; }
        //[JsonIgnore]
        public List<ItemImageViewModel> itemImageViewModels { get; set; }
    }
}
