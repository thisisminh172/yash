using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using yash.ViewModels.Catalog.ItemImages;
using yash.ViewModels.Catalog.Items;

namespace yash.WebApp.Models
{
    public class ItemDetailViewModel
    {
        public ItemViewModel Item { get; set; }
        public List<ItemImageViewModel> ItemImages { get; set; }
        public List<ItemViewModel> Items { get; set; }
    }
}
