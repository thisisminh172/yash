using System;
using System.Collections.Generic;
using System.Text;

namespace yash.Data.Entities
{
    public class ProductType
    {
        public int Id { get; set; }

        public string Name { get; set; }//rings, chains, pendants, solitaires

        public List<Item> Items { get; set; }
    }
}
