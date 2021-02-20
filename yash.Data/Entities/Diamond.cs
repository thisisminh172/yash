using System;
using System.Collections.Generic;
using System.Text;

namespace yash.Data.Entities
{
    public class Diamond
    {
        public int Id { get; set; }

        public string DiamondShape { get; set; }

        public float Price { get; set; }//per carat

        public List<Item> Items { get; set; }
    }
}
