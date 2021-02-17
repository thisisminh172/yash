using System;
using System.Collections.Generic;
using System.Text;

namespace yash.Data.Entities
{
    public class Admin
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public bool Role { get; set; }
    }
}
