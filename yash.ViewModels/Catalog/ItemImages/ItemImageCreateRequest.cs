using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace yash.ViewModels.Catalog.ProductImages
{
    public class ItemImageCreateRequest
    {
        public int SortOrder { get; set; }
        public bool IsDefault { get; set; }
        public IFormFile ImageFile { get; set; }
    }
}
