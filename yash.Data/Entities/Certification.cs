using System;
using System.Collections.Generic;
using System.Text;

namespace yash.Data.Entities
{
    public class Certification
    {
        public int Id { get; set; }
        public string CertifyType { get; set; }
        public string LinkUrl { get; set; }

        public List<Item> Items { get; set; }
    }
}
