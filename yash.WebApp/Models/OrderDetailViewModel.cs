using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using yash.ViewModels.Catalog.Carts;
using yash.ViewModels.Users;

namespace yash.WebApp.Models
{
    public class OrderDetailViewModel
    {
        public UserViewModel User { get; set; }
        public List<CartViewModel> Carts { get; set; }
    }
}
