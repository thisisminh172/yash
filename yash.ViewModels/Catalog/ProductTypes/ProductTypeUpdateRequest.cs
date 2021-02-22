using System;
using System.Collections.Generic;
using System.Text;

namespace yash.ViewModels.Catalog.ProductTypes
{
    public class ProductTypeUpdateRequest
    {
        public int Id { get; set; }

        public string Name { get; set; }//rings, chains, pendants, solitaires
    }
}
