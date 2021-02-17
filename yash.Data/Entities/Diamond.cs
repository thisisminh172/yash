using System;
using System.Collections.Generic;
using System.Text;

namespace yash.Data.Entities
{
    public class Diamond
    {
        public int Id { get; set; }

        public string DiamondType { get; set; }

        public string DiamondCarat { get; set; }

        public float Price { get; set; }

        public List<Item> Items { get; set; }
    }
}
