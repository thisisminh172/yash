using System;
using System.Collections.Generic;
using System.Text;

namespace yash.Data.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }//wedding, birthday, gift

        public List<Item> Items { get; set; }
    }
}
