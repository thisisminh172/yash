using System;
using System.Collections.Generic;
using System.Text;

namespace yash.Data.Entities
{
    public class Gold
    {
        public int Id { get; set; }

        public string GoldCarat { get; set; }//14k 18k 24k

        public float Price { get; set; }


        public List<Item> Items { get; set; }
    }
}
