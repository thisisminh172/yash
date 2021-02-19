using System;
using System.Collections.Generic;
using System.Text;

namespace yash.Data.Entities
{
    public class ItemImage
    {
        public int Id { get; set; }
        public int ItemId { get; set; }//FK
        public string ItemImageUrl { get; set; }
        public bool IsDefault { get; set; }
        public int SortOrder { get; set; }
        public virtual Item Item { get; set; }
    }
}
