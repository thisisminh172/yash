using System;
using System.Collections.Generic;
using System.Text;

namespace yash.Data.Entities
{
    public class ProductType
    {
        public int Id { get; set; }

        public string Name { get; set; }//ring, chain

        public List<Item> Items { get; set; }
    }
}
