using System;
using System.Collections.Generic;
using System.Text;

namespace yash.Data.Entities
{
    public class Brand
    {
        public int Id { get; set; }
        public string BrandType { get; set; }
        public List<Item> Items { get; set; }
    }
}
