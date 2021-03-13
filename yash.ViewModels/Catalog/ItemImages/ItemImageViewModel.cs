using System;
using System.Collections.Generic;
using System.Text;

namespace yash.ViewModels.Catalog.ItemImages
{
    public class ItemImageViewModel
    {
        //public int Id { get; set; }// co the ko can cai nay
        //public int ItemId { get; set; }//FK, co the ko can cai nay
        public string ItemImageUrl { get; set; }
        public bool IsDefault { get; set; }
        //public int SortOrder { get; set; }
    }
}
