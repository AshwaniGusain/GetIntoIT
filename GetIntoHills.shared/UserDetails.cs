using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetIntoHills.shared
{
    public class UserDetails
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Mobile_number { get; set; }
        public string email_address { get; set; }

        public string password { get; set; }

        // To do - Add encryption/decryption method to secure password.
        public bool IsDriver { get; set; }

    }
}
