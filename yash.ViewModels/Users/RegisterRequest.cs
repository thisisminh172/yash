using System;
using System.Collections.Generic;
using System.Text;

namespace yash.ViewModels.Users
{
    public class RegisterRequest
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public DateTime DOB { get; set; }

        public DateTime CurrentDate { get; set; }

        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
