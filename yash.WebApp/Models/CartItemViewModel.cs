using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using yash.ViewModels.Catalog.Carts;

namespace yash.WebApp.Models
{
    public class CartItemViewModel
    {
        public CartViewModel Cart { get; set; }
        public List<CartViewModel> Carts { get; set; }
    }
}
