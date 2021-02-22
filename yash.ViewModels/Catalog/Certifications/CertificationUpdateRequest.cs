using System;
using System.Collections.Generic;
using System.Text;

namespace yash.ViewModels.Catalog.Certifications
{
    public class CertificationUpdateRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LinkUrl { get; set; }
    }
}
