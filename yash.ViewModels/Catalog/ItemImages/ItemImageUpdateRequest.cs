using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace yash.ViewModels.Catalog.ItemImages
{
    public class ItemImageUpdateRequest
    {
        public int Id { get; set; }
        public int SortOrder { get; set; }
        public bool IsDefault { get; set; }
        public IFormFile ImageFile { get; set; }
    }
}
