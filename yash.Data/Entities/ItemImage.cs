using System;
using System.Collections.Generic;
using System.Text;

namespace yash.Data.Entities
{
    public class ItemImage
    {
        public int Id { get; set; }
        public int ItemId { get; set; }//FK
        public string ItemImageUrl { get; set; }//json list
        public virtual Item Item { get; set; }
    }
}
