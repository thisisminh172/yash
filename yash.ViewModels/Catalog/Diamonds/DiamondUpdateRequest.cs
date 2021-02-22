using System;
using System.Collections.Generic;
using System.Text;

namespace yash.ViewModels.Catalog.Diamonds
{
    public class DiamondUpdateRequest
    {
        public int Id { get; set; }

        public string DiamondShape { get; set; }

        public float Price { get; set; }//per carat
    }
}
