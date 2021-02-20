using System;
using System.Collections.Generic;
using System.Text;

namespace yash.Data.Entities
{
    public class Gold
    {
        public int Id { get; set; }

        public string GoldCarat { get; set; }//14kt 18kt

        public float Price { get; set; }// per ounce, USD


        public List<Item> Items { get; set; }
    }
}
